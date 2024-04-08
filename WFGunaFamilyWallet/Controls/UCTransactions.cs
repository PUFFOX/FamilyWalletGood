using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WFGunaFamilyWallet.models;

namespace WFGunaFamilyWallet.Controls
{
    public partial class UCTransactions : UserControl
    {

        public BudgetContext dbContext = new BudgetContext();
        public BindingSource bindingSourceTransactions = new BindingSource();


        // Додайте делегат та подію у клас UCTransaction
        public delegate void SaveTransactionEventHandler(object sender, EventArgs e);
        public event SaveTransactionEventHandler OnSaveTransaction;


        public event EventHandler TransactionSaved;

        // Метод, який викликає подію, коли транзакція збережена
        protected virtual void OnTransactionSaved()
        {
            TransactionSaved?.Invoke(this, EventArgs.Empty);
        }

        public string LoggedInUsername
        {
            get { return labTrans.Text; }
            set { labTrans.Text = value; }
        }


        public UCTransactions()
        {
            InitializeComponent();

            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;


            cmbCategories_SelectedIndexChanged(cmbCategories, EventArgs.Empty);
            cmbUsers_SelectedIndexChanged(cmbUsers, EventArgs.Empty);

            ClearComboBoxesAndText();
            UpdateBase();


        }

        private void StartComboBoxesAndText()
        {
            cmbUsers.Text = "-Оберіть користувача-";
            cmbUsers.ForeColor = Color.Purple;

            cmbCategories.Text = "-Оберіть категорію-";
            cmbCategories.ForeColor = Color.Purple;

            toolTip1.SetToolTip(txtAmount, "Введіть ціну");
            toolTip1.SetToolTip(txtComment, "Введіть комент");

            txtComment.Text = "";
        }

        private void ClearComboBoxesAndText()
        {
            cmbUsers.SelectedIndex = -1;
            cmbCategories.SelectedIndex = -1;
            txtComment.Text = "";
        }


        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            string comment = txtComment.Text;
        }


        private int GetOrCreateDescriptionId(string comment)
        {
            // Пошук опису за текстом коментаря
            Description existingDescription = dbContext.Descriptions.FirstOrDefault(d => d.Comment == comment);

            // Якщо опис не знайдено, створити новий опис
            if (existingDescription == null)
            {
                existingDescription = new Description { Comment = comment };
                dbContext.Descriptions.Add(existingDescription);
                dbContext.SaveChanges(); 
            }

            return existingDescription.Id;
        }


        public void UpdateBase()
        {
            dbContext.SaveChanges();

            cmbCategories.DataSource = dbContext.Categories.ToList();
            cmbCategories.DisplayMember = "NameCategory";
            cmbCategories.ValueMember = "Id";

            cmbUsers.DataSource = dbContext.Users.ToList();
            cmbUsers.DisplayMember = "Username";
            cmbUsers.ValueMember = "Id";


            // Отримуємо один запис із таблиці Descriptions
            Description description = dbContext.Descriptions.FirstOrDefault();

            // Перевіряємо, чи є запис у таблиці
            if (description != null)
            {
                // Встановлюємо текстовий змінний вміст TextBox
                txtComment.Text = description.Comment;
            }

            StartComboBoxesAndText();

        }


        private void ClearTransactionFields()
        {

            dateTimePicker.Value = DateTime.Now;

            cmbUsers.Text = "-Оберіть користувача-";
            cmbUsers.ForeColor = Color.Purple; 
          
            cmbCategories.Text = "-Оберіть категорію-";
            cmbCategories.ForeColor = Color.Purple; 

            txtComment.Clear();
            txtAmount.Clear();

            //rbtnIncome.Checked = false;

        }


        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategories.Text;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = cmbUsers.Text;
        }

        private void cmbUsers_Enter(object sender, EventArgs e)
        {
            if (cmbUsers.Text == "Оберіть користувача")
            {
                cmbUsers.ForeColor = Color.Purple; // Зміна кольору тексту на чорний
            }
        }

        private void cmbUsers_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbUsers.Text))
            {
                cmbUsers.ForeColor = Color.Purple; // Зміна кольору тексту на сірий
            }
        }

        private void cmbCategories_Enter(object sender, EventArgs e)
        {
            if (cmbCategories.Text == "Оберіть категорію")
            {
                cmbCategories.ForeColor = Color.Purple; // Зміна кольору тексту на чорний
            }
        }

        private void cmbCategories_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCategories.Text))
            {
                cmbCategories.ForeColor = Color.Purple; // Зміна кольору тексту на сірий
            }
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedUser = cmbUsers.Text;

                if (selectedUser != labTrans.Text)
                {
                    MessageBox.Show("Ви можете створювати транзакції тільки під своїм аккаунтом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbUsers.SelectedItem == null)
                {
                    MessageBox.Show("Будь ласка, оберіть користувача.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (cmbCategories.SelectedItem == null)
                {
                    MessageBox.Show("Будь ласка, оберіть категорію.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtComment.Text))
                {
                    MessageBox.Show("Будь ласка, введіть коментар.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtAmount.Text))
                {
                    MessageBox.Show("Будь ласка, введіть суму.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Transaction.TransactionType transactionType = rbtnIncome.Checked
                    ? Transaction.TransactionType.Income
                    : Transaction.TransactionType.Expense;

                Transaction newTransaction = new Transaction
                {
                    DateTime = dateTimePicker.Value,
                    UserId = (int)cmbUsers.SelectedValue,
                    CategoryId = (int)cmbCategories.SelectedValue,
                    DescriptionId = GetOrCreateDescriptionId(txtComment.Text),
                    Amount = decimal.Parse(txtAmount.Text),
                    Type = transactionType
                };

                dbContext.Transactions.Add(newTransaction);
                dbContext.SaveChanges();  // Збереження транзакції

                MessageBox.Show("Транзакцію збережено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnSaveTransaction?.Invoke(this, EventArgs.Empty);

                // Виклик події, щоб сповістити про збереження транзакції
                OnTransactionSaved();
                UpdateBase();

                ClearTransactionFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні транзакції: {ex.Message}");
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        public event EventHandler Event;
    }


}

