using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WFGunaFamilyWallet.models;

namespace WFGunaFamilyWallet.ChildForm
{
    public partial class AddFormUser : Form
    {

        // Властивість, що зберігає ім'я нового користувача
        public string NewUser { get; private set; }

        // Конструктор форми додавання користувача
        public AddFormUser()
        {
            // Створення об'єкта ToolTip
            ToolTip toolTip1 = new ToolTip();

            InitializeComponent();
            // Встановлення позиції по центру екрану
            this.StartPosition = FormStartPosition.CenterScreen;
            // Встановлення AcceptButton для виклику btnAdd_Click при натисканні Enter
            this.AcceptButton = bntLoginUser;

            // Оновлення випадаючого списку користувачів
            UpdateUsersComboBox();
            ClearComboBoxesAndText();

            // Встановлення сірого тексту під час завантаження форми
            cmbUsersLogin.Text = "-Оберіть користувача-";
            cmbUsersLogin.ForeColor = Color.Purple; // Початковий колір тексту - сірий

            // Додавання підказки для txtPasswordLogin
            toolTip1.SetToolTip(txtPasswordLogin, "Введіть пароль");
            toolTip1.SetToolTip(txtPasswordLogin, "Введіть пароль");

        }

        

        private void ClearComboBoxesAndText()
        {
            cmbUsersLogin.SelectedIndex = -1;
        }



        // Перевірка пароля
        private bool CheckPassword(string enteredPassword, string username)
        {
            using (var dbContext = new BudgetContext())
            {
                // Отримання користувача за ім'ям
                var user = dbContext.Users.FirstOrDefault(u => u.Username == username);

                // Перевірка, чи користувач знайдений і чи співпадають паролі
                return user != null && string.Equals(enteredPassword, user.Password);
            }
        }

        // Обробник події кнопки закриття форми додавання користувача
        private void bntCloseAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Метод для оновлення випадаючого списку користувачів
        private void UpdateUsersComboBox()
        {
            using (var dbContext = new BudgetContext())
            {
                cmbUsersLogin.DataSource = dbContext.Users.ToList();
                cmbUsersLogin.DisplayMember = "Username";
                cmbUsersLogin.ValueMember = "Id";
            }
        }

        private void cmbUsersLogin_Enter(object sender, EventArgs e)
        {
            if (cmbUsersLogin.Text == "Оберіть користувача")
            {
                cmbUsersLogin.ForeColor = Color.Black; // Зміна кольору тексту на чорний
            }
        }

        private void cmbUsersLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbUsersLogin.Text))
            {
                cmbUsersLogin.ForeColor = Color.Gray; // Зміна кольору тексту на сірий
            }
        }

        private void btnRegLogin_Click(object sender, EventArgs e)
        {   
            // Відкриття форми реєстрації
            using (var addFormRegister = new FormRegister())
            {
                if (addFormRegister.ShowDialog() == DialogResult.OK)
                {
                    string newUser = addFormRegister.NewUserReg;
                    this.Close();
                } 

            }
            this.Close();
        }

        private void bntLoginUser_Click(object sender, EventArgs e)
        {

            string username = cmbUsersLogin.Text;

            string password = txtPasswordLogin.Text;

            // Перевірка пароля
            if (CheckPassword(password, username))
            {
                // Відкриття головної форми
                using (var mainForm = new MainForm(username))
                {
                    mainForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неправильний пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
