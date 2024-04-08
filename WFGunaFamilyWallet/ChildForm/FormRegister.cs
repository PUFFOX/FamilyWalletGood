using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGunaFamilyWallet.models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WFGunaFamilyWallet.ChildForm
{
    public partial class FormRegister : Form
    {
        //private BudgetContext dbContext = new BudgetContext();

        public string NewUserReg { get; private set; }

        public FormRegister()
        {
            InitializeComponent();
            // Встановлення позиції по центру екрану
            this.StartPosition = FormStartPosition.CenterScreen;
            // Встановлення AcceptButton для виклику btnAdd_Click при натисканні Enter
            this.AcceptButton = bntSaveNewUser;
            // Оновлення бази (можливо, ви маєте метод UpdateBase, який ви зараз коментуєте)
            // UpdateBase();
        }




        // Закриває поточне вікно реєстрації
        private void bntCloseAddUserReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnHaveAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            // Відкриває форму для додавання нового користувача
            using (var addFormUser = new AddFormUser())
            {
                if (addFormUser.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                }
            }
            this.Hide();
            //this.Close();
        }

        private void bntSaveNewUser_Click(object sender, EventArgs e)
        {
            string usernameReg = txtUsernameReg.Text;
            string passwordReg = txtPasswordReg.Text;

            using (var dbContext = new BudgetContext())
            {
                if (!string.IsNullOrEmpty(usernameReg) && !string.IsNullOrEmpty(passwordReg))
                {
                    try
                    {
                        // Перевірка чи існує користувач з таким ім'ям вже в базі даних
                        bool userExists = dbContext.Users.Any(u => u.Username == usernameReg);

                        if (userExists)
                        {
                            // Виводить повідомлення про помилку, якщо користувач вже існує
                            MessageBox.Show("Користувач з таким ім'ям вже існує. Виберіть інше ім'я.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!Regex.IsMatch(usernameReg, @"^[\p{L}a-zA-Z]{1,7}$"))
                        {
                            // Перевірка
                            MessageBox.Show("Ім'я користувача повинно складатися з букв і не більше 7 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Додає нового користувача, якщо його не існує
                            dbContext.AddUser(usernameReg, passwordReg);
                            dbContext.SaveChanges();

                            MessageBox.Show("Користувача додано успішно!");

                            // Очищає текстові поля та фокусується на полі для введення ім'я користувача
                            txtUsernameReg.Clear();
                            txtPasswordReg.Clear();
                            txtUsernameReg.Focus();

                            this.Hide();

                            using (var mainForm = new MainForm(usernameReg))
                            {
                                mainForm.ShowDialog();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть ім'я користувача та пароль.");
                }
            }
        }
    }

}

