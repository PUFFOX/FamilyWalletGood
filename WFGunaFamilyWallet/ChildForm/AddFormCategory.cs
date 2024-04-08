using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGunaFamilyWallet.models;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;
using WFGunaFamilyWallet.Controls;
using System.Text.RegularExpressions;

namespace WFGunaFamilyWallet.ChildForm
{
    public partial class AddFormCategory : Form
    {
        public BudgetContext dbContext = new BudgetContext();

        UCTransactions controlTransactions = new UCTransactions();
        public string NewCategory { get; private set; }



        public AddFormCategory()
        {
            InitializeComponent();
            // Встановлення позиції по центру екрану
            this.StartPosition = FormStartPosition.CenterScreen;
            // Встановлення AcceptButton для виклику btnAdd_Click при натисканні Enter
            this.AcceptButton = bntSaveNewCatelory;


        }



        public void AddCategory(string categoryName)
        {
            // Створення нового об'єкта категорії
            Category newCategory = new Category { NameCategory = categoryName };

            // Додавання нової категорії до контексту бази даних
            dbContext.Categories.Add(newCategory);

            // Збереження змін у базі даних
            dbContext.SaveChanges();
            controlTransactions.UpdateBase();
        }


        private void bntSaveNewCatelory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bntSaveNewCatelory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bntSaveNewCatelory_Click(sender, e);
            }
        }

        private void bntCloseAddCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSaveNewCatelory_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = txtAddCategory.Text.Trim();

                if (!string.IsNullOrEmpty(categoryName))
                {
                    // Перевірка наявності лише букв та обмеження до 10 символів
                    if (Regex.IsMatch(categoryName, @"^[a-zA-Zа-яА-Я]{3,10}$"))
                    {
                        dbContext.AddCategory(categoryName);
                        dbContext.SaveChanges();
                        MessageBox.Show("Категорію додано успішно!");


                        txtAddCategory.Clear();
                        txtAddCategory.Focus();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Назва категорії повинна містити тільки букви та не більше 10 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть назву категорії.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
