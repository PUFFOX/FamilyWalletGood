using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WFGunaFamilyWallet.ChildForm;
using WFGunaFamilyWallet.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WFGunaFamilyWallet.Controls
{
    public partial class UCSettings : UserControl
    {
      
        public BudgetContext dbContext = new BudgetContext();

        // Конструктор класу
        public UCSettings()
        {
            InitializeComponent();
            UpdateBase();

            // Додавання обробників подій для вибору випадаючих списків
            cmbSettingsEditCategory.SelectedIndexChanged += cmbSettingsEditCategory_SelectedIndexChanged;
            cmbSettingsEditUsers.SelectedIndexChanged += cmbSettingsEditUsers_SelectedIndexChanged;

            //cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;

            // Виклик події вибору категорії для початкового завантаження даних
            cmbSettingsEditCategory_SelectedIndexChanged(cmbSettingsEditCategory, EventArgs.Empty);
            cmbSettingsEditCategory_SelectedIndexChanged(cmbSettingsEditCategory, EventArgs.Empty);


            // Очищення комбобоксів та текстових полів
            ClearComboBoxesAndText();


        }

        // Метод для оновлення випадаючих списків та списку
        private void UpdateBase()
        {
            // Завантаження категорій та користувачів з бази даних
            cmbSettingsEditCategory.DataSource = dbContext.Categories.ToList();
            cmbSettingsEditCategory.DisplayMember = "NameCategory";
            cmbSettingsEditCategory.ValueMember = "Id";

            cmbSettingsEditUsers.DataSource = dbContext.Users.ToList();
            cmbSettingsEditUsers.DisplayMember = "Username";
            cmbSettingsEditUsers.ValueMember = "Id";


            // Оновлення списку
            UpdateListView();
        }

        // Метод очищення випадаючих списків та текстових полів
        private void ClearComboBoxesAndText()
        {
            //cmbSettingsEditUsers.SelectedIndex = -1;
            //cmbSettingsEditCategory.SelectedIndex = -1;

            // Встановлення сірого тексту під час завантаження форми
            cmbSettingsEditUsers.Text = "-Оберіть користувача-";
            cmbSettingsEditUsers.ForeColor = Color.Purple; // Початковий колір тексту - сірий

            // Встановлення сірого тексту під час завантаження форми
            cmbSettingsEditCategory.Text = "-Оберіть категорію-";
            cmbSettingsEditCategory.ForeColor = Color.Purple; // Початковий колір тексту - сірий

        }

        // Обробник події вибору користувача в списку
        private void cmbSettingsEditUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSettingsUser = cmbSettingsEditCategory.Text;
        }

        // Обробник події вибору категорії в списку
        private void cmbSettingsEditCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSettingsCategory = cmbSettingsEditCategory.Text;
        }

        // Оновлення списку транзакцій
        private void UpdateListView()
        {
            try
            {
                // Дані транзакцій з бази даних
                var transactions = dbContext.Transactions
                    .Include(t => t.User)
                    .Include(t => t.Category)
                    .Include(t => t.Description)
                    .ToList();

                foreach (var transaction in transactions)
                {
                    var item = new ListViewItem(transaction.Id.ToString());

                    item.SubItems.Add(transaction.DateTime.ToShortDateString());
                    item.SubItems.Add(transaction.Type.ToString());
                    item.SubItems.Add(transaction.Category?.NameCategory ?? "");
                    item.SubItems.Add(transaction.Amount.ToString());
                    item.SubItems.Add(transaction.User?.Username ?? "");
                    item.SubItems.Add(transaction.Description?.Comment ?? "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($" {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCSettings_Load(object sender, EventArgs e)
        {
            // Встановлення сірого тексту під час завантаження форми
            cmbSettingsEditUsers.Text = "-Оберіть користувача-";
            cmbSettingsEditUsers.ForeColor = Color.Gray;

            // Встановлення сірого тексту під час завантаження форми
            cmbSettingsEditCategory.Text = "-Оберіть категорію-";
            cmbSettingsEditCategory.ForeColor = Color.Gray;
        }



        private void btnSettingsAddCategory_Click(object sender, EventArgs e)
        {
            // Додавання нової категорії через вікно діалогу
            using (var addFormCategory = new AddFormCategory())
            {
                if (addFormCategory.ShowDialog() == DialogResult.OK)
                {
                    string newCategory = addFormCategory.NewCategory;
                }
            }
            // Оновлення даних та очищення вибору
            UpdateBase();
            ClearComboBoxesAndText();
        }

        private void btnSettingDeleteCategory_Click(object sender, EventArgs e)
        {
            // Видалення вибраної категорії
            if (cmbSettingsEditCategory.SelectedItem != null && cmbSettingsEditCategory.Text != "-Оберіть категорію-")
            {
                var selectedCategory = (Category)cmbSettingsEditCategory.SelectedItem;
                string categoryName = selectedCategory.NameCategory;

                string message = $"Ви впевнені, що бажаєте видалити категорію '{categoryName}'?";
                string caption = "Підтвердження видалення";

                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Категорію {categoryName} видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbContext.Categories.Remove(selectedCategory);
                    dbContext.SaveChanges();

                    // Оновлення даних та очищення вибору
                    UpdateBase();
                    ClearComboBoxesAndText();

                }
            }
            else
            {
                MessageBox.Show("Оберіть категорію...", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSettingsAddUser_Click(object sender, EventArgs e)
        {
            // Додавання нового користувача через вікно діалогу
            using (var addFormUser = new AddFormUser())
            {
                if (addFormUser.ShowDialog() == DialogResult.OK)
                {
                    string newUser = addFormUser.NewUser;
                }
            }
            // Оновлення даних та очищення вибору
            UpdateBase();
            ClearComboBoxesAndText();
        }

        private void btnSettingDeleteUser_Click(object sender, EventArgs e)
        {
            // Видалення вибраного користувача
            if (cmbSettingsEditUsers.SelectedItem != null && cmbSettingsEditUsers.Text != "-Оберіть користувача-")
            {
                var selectedUser = (User)cmbSettingsEditUsers.SelectedItem;
                string userName = selectedUser.Username;

                string message = $"Ви впевнені, що бажаєте видалити '{userName}'?";
                string caption = "Підтвердження видалення";

                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Користувача {userName} видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbContext.Users.Remove(selectedUser);
                    dbContext.SaveChanges();

                    // Оновлення даних та очищення вибору
                    UpdateBase();
                    ClearComboBoxesAndText();
                }
            }
            else
            {
                MessageBox.Show("Оберіть користувача...", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearDatabase_Click(object sender, EventArgs e)
        {
            // Запит користувача на підтвердження видалення всіх даних
            DialogResult result = MessageBox.Show("Ви впевнені, що бажаєте очистити базу даних? Ця дія є необоротною.", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Видалення всіх транзакцій з бази даних
                    dbContext.Transactions.RemoveRange(dbContext.Transactions);
                    dbContext.SaveChanges();

                    UpdateBase();
                    ClearComboBoxesAndText();
                    MessageBox.Show("Базу даних успішно очищено.", "Очищення бази даних", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при очищенні бази даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







       

       

        







    }
    

}
