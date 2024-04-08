using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFGunaFamilyWallet.models;

namespace WFGunaFamilyWallet.Controls
{
    //public partial class UCSupport : UserControl
    //{
    //    public UCSupport()
    //    {
    //        InitializeComponent();
    //        DescriptionForUsers();
    //    }

    //    public void DescriptionForUsers()
    //    {
    //        txtHi.Text = "Наш додаток сімейного бюджету - це зручний інструмент для ефективного керування фінансами вашої сім'ї. " +
    //            "Він дозволяє вам легко відстежувати доходи, витрати та бюджетні плани всієї родини, сприяючи фінансовій дисципліні " +
    //            "та спільній управлінню грошима.";

    //        // Додати місце для зворотнього зв'язку
    //        lblReportIssue.Text = "Знайшли проблему або маєте пропозиції?";
    //        lblReportIssue.LinkClicked += (sender, e) =>
    //        {
    //            // Отримати зворотній зв'язок
    //            MessageBox.Show("Будь ласка, зверніться до служби підтримки за адресою support@example.com", "Зворотній зв'язок",
    //                MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        };
    //    }

    //    // Обробник події для вибору елемента випадаючого списку
    //    private void comboBoxSupport_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        // Отримання вибраного питання або проблеми
    //        string selectedQuestion = comboBoxSupport.SelectedItem.ToString();

    //        // Відображення відповідного пояснення або рекомендації
    //        DisplayExplanation(selectedQuestion);
    //    }

    //    // Метод для відображення пояснення або рекомендації
    //    private void DisplayExplanation(string selectedQuestion)
    //    {
    //        // Приклад пояснень для кількох питань
    //        string explanation = "";

    //        switch (selectedQuestion)
    //        {
    //            case "Як змінити користувача?":
    //                explanation = "Для зміни користувача перейдіть до вкладки Налаштування та знайдіть розділ Користувачі.";
    //                break;
    //            case "Як відновити пароль?":
    //                explanation = "Для відновлення паролю скористайтеся функцією 'Забули пароль' на екрані входу.";
    //                break;
    //            // Додайте інші варіанти пояснень за потреби
    //            default:
    //                explanation = "Вибачте, пояснення для цього питання ще не додано.";
    //                break;
    //        }

    //        // Відображення пояснення у текстовому полі або мітці
    //        labelExplanation.Text = explanation;
    //    }

    //    // Обробник події для кнопки зв'язку з підтримкою
    //    private void buttonContactSupport_Click(object sender, EventArgs e)
    //    {
    //        // Додайте код для зв'язку з підтримкою, наприклад, відкриття нового вікна або відправлення електронного листа
    //    }


    //}

    public partial class UCSupport : UserControl
    {
        public UCSupport()
        {
            InitializeComponent();
            DescriptionForUsers();
            InitializeQuestions();
        }


        public void DescriptionForUsers()
        {
            txtHi.Text = "Наш додаток сімейного бюджету - це зручний інструмент для ефективного керування фінансами вашої сім'ї. " +
                "Він дозволяє вам легко відстежувати доходи, витрати та бюджетні плани всієї родини, сприяючи фінансовій дисципліні " +
                "та спільній управлінню грошима.";


            lblReportIssue.Text = "Знайшли проблему або маєте пропозиції?";
            lblReportIssue.LinkClicked += (sender, e) =>
            {

                MessageBox.Show("Будь ласка, зверніться до служби підтримки за адресою support@example.com", "Зворотній зв'язок",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
        }


        private void InitializeQuestions()
        {
            // випадаючий список
            comboBoxSupport.Items.AddRange(new string[] 
            { "Як змінити користувача?", 
                "Як видалити всі транзакції?",
                "Для чого потрібна кнопка гаманця?"


            });
        }


        private void comboBoxSupport_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримання вибраного питання або проблеми
            string selectedQuestion = comboBoxSupport.SelectedItem.ToString();

            // Відображення відповідного пояснення або рекомендації
            DisplayExplanation(selectedQuestion);
        }


        private void DisplayExplanation(string selectedQuestion)
        {

            string explanation = "";

            switch (selectedQuestion)
            {
                case "Як змінити користувача?":
                    explanation = "Для зміни користувача перейдіть до вкладки Налаштування та знайдіть розділ Користувачі.";
                    break;
                case "Як видалити всі транзакції?":
                    explanation = "Для видалення транзакції скористайтеся кнопкою 'Видалити транзакції' на вкладці Налаштування.";
                    break;
                case "Для чого потрібна кнопка гаманця?":
                    explanation = "Кнопка виконує оновлення додатка та повернення на вкладку Історія";
                    break;
                default:
                    explanation = "Вибачте, пояснення для цього питання ще не додано.";
                    break;
            }

            // Відображення 
            textBox1.Text = explanation;
        }

    }
}
