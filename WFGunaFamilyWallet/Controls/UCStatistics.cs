using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WFGunaFamilyWallet.models;
using System.Collections.Generic;
using LiveCharts.Helpers;

namespace WFGunaFamilyWallet.Controls
{

    public partial class UCStatistics : UserControl
    {
        private BudgetContext dbContext = new BudgetContext();


        UCTransactions controlTransactions = new UCTransactions();

        public UCStatistics()
        {
            InitializeComponent();

            controlTransactions.UpdateBase();

            InitializeListViewColumns(listView1);
            InitializeListViewColumns(listView2);
            InitializeListViewColumns2(listView3);


            cmbAllIncomesStatistics.Items.AddRange(CultureInfo.GetCultureInfo("uk-UA").DateTimeFormat.MonthNames.Take(12).ToArray());

            cmbAllExpensesStatistics.Items.AddRange(CultureInfo.GetCultureInfo("uk-UA").DateTimeFormat.MonthNames.Take(12).ToArray());

            cmbMonth.Items.AddRange(CultureInfo.GetCultureInfo("uk-UA").DateTimeFormat.MonthNames.Take(12).ToArray());


            cmbAllIncomesStatistics.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbAllExpensesStatistics.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;



            UpdateIncomeListView(listView1, cmbAllIncomesStatistics);

            UpdateExpenseListView(listView2, cmbAllExpensesStatistics);

            UpdateTotalIncomeLabel();
            UpdateTotalExpenseLabel();

        }

        private void InitializeListViewColumns(ListView listView)
        {
            if (listView.Columns.Count == 0)
            {
                listView.Columns.Add("№", 25);
                listView.Columns.Add("Дата", 75);
                listView.Columns.Add("Тип", 65);
                listView.Columns.Add("Категорія", 100);
                listView.Columns.Add("Сума", 80);
                listView.Columns.Add("Користувач", 65);
                listView.Columns.Add("Комантар", 155);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var comboBox = (ComboBox)sender;

            // Виклик для доходів
            UpdateIncomeListView(listView1, cmbAllIncomesStatistics);

            // Виклик для витрат
            UpdateExpenseListView(listView2, cmbAllExpensesStatistics);


            // Оновлення лейблів
            UpdateTotalIncomeLabel();
            UpdateTotalExpenseLabel();

            // Оновлення графіка доходів за обраним місяцем
            int selectedMonthIndex = comboBox.SelectedIndex + 1;
            UpdateIncomeCategoryChart(selectedMonthIndex);

            // Оновлення графіка витрат за обраним місяцем
            UpdateExpenseCategoryChart(selectedMonthIndex);

            // Оновлення кругової діаграми витрат за обраним місяцем
            UpdateExpenseCategoryPieChart(selectedMonthIndex);
        }

        private void UpdateIncomeListView(ListView listView, ComboBox comboBox)
        {
            UpdateListView(listView, comboBox, Transaction.TransactionType.Income);
        }

        private void UpdateExpenseListView(ListView listView, ComboBox comboBox)
        {
            UpdateListView(listView, comboBox, Transaction.TransactionType.Expense);
        }

        
        private void UpdateListView(ListView listView, ComboBox comboBox, Transaction.TransactionType transactionType)
        {
            try
            {
                // Очищення ListView перед додаванням нових елементів
                listView.Items.Clear();

                // Отримання індексу вибраного місяця
                int selectedMonthIndex = comboBox.SelectedIndex + 1;

                // Фільтрація транзакцій за обраним місяцем та типом
                var transactions = dbContext.Transactions
                    .Include(t => t.User)
                    .Include(t => t.Category)
                    .Include(t => t.Description)
                    .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == transactionType)
                    .ToList();

                int transactionNumber = 1; // Лічильник транзакцій

                // Додавання транзакцій до ListView
                foreach (var transaction in transactions)
                {
                    var item = new ListViewItem(transactionNumber.ToString()); // Встановлення номера транзакції
                    transactionNumber++; // Інкремент лічильника

                    // Додавання підстовпців до елемента ListView
                    item.SubItems.Add(transaction.DateTime.ToShortDateString());
                    item.SubItems.Add(transaction.Type == Transaction.TransactionType.Income ? "Дохід" : "Витрата");
                    item.SubItems.Add(transaction.Category?.NameCategory ?? "");
                    item.SubItems.Add(transaction.Amount.ToString("C"));
                    item.SubItems.Add(transaction.User?.Username ?? "");
                    item.SubItems.Add(transaction.Description?.Comment ?? "");

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні ListView: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateTotalIncomeLabel()
        {
            int selectedMonthIndex = cmbAllIncomesStatistics.SelectedIndex + 1;
            decimal totalIncome = CalculateTotalAmount(selectedMonthIndex, Transaction.TransactionType.Income);
            labelTotalIncome.Text = $"Загальний дохід: {totalIncome:C}";

        }

        private void UpdateTotalExpenseLabel()
        {
            int selectedMonthIndex = cmbAllExpensesStatistics.SelectedIndex + 1;
            decimal totalExpense = CalculateTotalAmount(selectedMonthIndex, Transaction.TransactionType.Expense);
            labelTotalExpense.Text = $"Загальна витрата: {totalExpense:C}";

        }

        private decimal CalculateTotalAmount(int selectedMonthIndex, Transaction.TransactionType transactionType)
        {
            // Отримання суми транзакцій за обраний місяць і тип транзакції
            decimal totalAmount = dbContext.Transactions
                .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == transactionType)
                .Select(t => t.Amount)
                .DefaultIfEmpty()
                .Sum();

            return totalAmount;
        }

        private void InitializeListViewColumns2(ListView listView)
        {
            if (listView.Columns.Count == 0)
            {
                listView.Columns.Add("Категорія", 150);
                listView.Columns.Add("Сума", 80);
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                int selectedMonthIndex = comboBox.SelectedIndex + 1;

                // Оновлення списку витрат за категоріями для обраного місяця
                UpdateExpenseListByCategory(selectedMonthIndex);

                // Оновлення кругової діаграми витрат за обраним місяцем
                UpdateExpenseCategoryPieChart(selectedMonthIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при виборі місяця: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateExpenseListByCategory(int selectedMonthIndex)
        {
            listView3.Items.Clear(); // Очищення списку перед оновленням

            // Отримання списку витрат за обраний місяць
            var expensesByCategory = dbContext.Transactions
                .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == Transaction.TransactionType.Expense)
                .GroupBy(t => t.Category.NameCategory)
                .Select(g => new { Category = g.Key, TotalAmount = g.Sum(t => t.Amount) })
                .OrderByDescending(g => g.TotalAmount)
                .ToList();

            decimal totalExpense = expensesByCategory.Sum(expense => expense.TotalAmount);

            // Записати загальну суму витрат за обраний місяць у labelCategoryExpense
            labelCategoryExpenses.Text = $"Total Expenses: {totalExpense:C}";

            // Додавання витрат у ListView за категоріями та сумами
            foreach (var expense in expensesByCategory)
            {
                ListViewItem item = new ListViewItem(expense.Category);
                item.SubItems.Add(expense.TotalAmount.ToString("C")); // Форматування суми

                listView3.Items.Add(item);
            }
        }


        private void UCStatistics_Load(object sender, EventArgs e)
        {
            cmbAllIncomesStatistics.Text = "-Оберіть місяць-";
            cmbAllIncomesStatistics.ForeColor = Color.Purple;

            cmbAllExpensesStatistics.Text = "-Оберіть місяць-";
            cmbAllExpensesStatistics.ForeColor = Color.Purple;

            cmbMonth.Text = "-Оберіть місяць-";
            cmbMonth.ForeColor = Color.Purple;

        }

        private void cmbAllIncomesStatistics_Enter(object sender, EventArgs e)
        {
            if (cmbAllIncomesStatistics.Text == "-Оберіть місяць-")
            {
                cmbAllIncomesStatistics.ForeColor = Color.Purple; // Зміна кольору тексту на чорний
            }
        }
        private void cmbAllIncomesStatistics_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbAllIncomesStatistics.Text))
            {
                cmbAllIncomesStatistics.ForeColor = Color.Purple; // Зміна кольору тексту на сірий
            }
        }

        private void cmbAllExpensesStatistics_Enter(object sender, EventArgs e)
        {
            if (cmbAllExpensesStatistics.Text == "-Оберіть місяць-")
            {
                cmbAllExpensesStatistics.ForeColor = Color.Purple; // Зміна кольору тексту на чорний
            }
        }
        private void cmbAllExpensesStatistics_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbAllExpensesStatistics.Text))
            {
                cmbAllExpensesStatistics.ForeColor = Color.Purple; // Зміна кольору тексту на сірий
            }
        }






        private void UpdateIncomeCategoryChart(int selectedMonthIndex)
        {
            // Очистити серії на графіку
            cartesianChart1.Series.Clear();

            // Отримати список унікальних категорій доходів для обраного місяця
            var incomeCategories = dbContext.Transactions
                .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == Transaction.TransactionType.Income)
                .Select(t => t.Category.NameCategory)
                .Distinct()
                .ToList();

            // Для кожної категорії побудувати серію даних на графіку
            foreach (var category in incomeCategories)
            {
                // Отримати суму доходу для кожної категорії
                decimal categoryTotalAmount = dbContext.Transactions
                    .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == Transaction.TransactionType.Income && t.Category.NameCategory == category)
                    .Select(t => t.Amount)
                    .DefaultIfEmpty()
                    .Sum();

                // Додати серію на графік
                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = category,
                    Values = new ChartValues<decimal> { categoryTotalAmount }
                });
            }
        }


        private void UpdateExpenseCategoryChart(int selectedMonthIndex)
        {
            // Очистити серії на графіку
            cartesianChart2.Series.Clear();

            // Отримати список унікальних категорій витрат для обраного місяця
            var expenseCategories = dbContext.Transactions
                .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == Transaction.TransactionType.Expense)
                .Select(t => t.Category.NameCategory)
                .Distinct()
                .ToList();

            // Для кожної категорії побудувати серію даних на графіку
            foreach (var category in expenseCategories)
            {
                // Отримати суму витрат для кожної категорії
                decimal categoryTotalAmount = dbContext.Transactions
                    .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == Transaction.TransactionType.Expense && t.Category.NameCategory == category)
                    .Select(t => t.Amount)
                    .DefaultIfEmpty()
                    .Sum();

                // Додати серію на графік
                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = category,
                    Values = new ChartValues<decimal> { categoryTotalAmount }
                });
            }
        }

        private void UpdateExpenseCategoryPieChart(int selectedMonthIndex)
        {
            // Очистити дані діаграми
            pieChart1.Series.Clear();

            // Отримати суму витрат за обраний місяць
            decimal totalExpense = CalculateTotalAmount(selectedMonthIndex, Transaction.TransactionType.Expense);

            // Отримати дані для кругової діаграми
            var expenseCategories = dbContext.Transactions
                .Where(t => t.DateTime.Month == selectedMonthIndex && t.Type == Transaction.TransactionType.Expense)
                .GroupBy(t => t.Category.NameCategory)
                .Select(g => new { Category = g.Key, TotalAmount = g.Sum(t => t.Amount) })
                .OrderByDescending(g => g.TotalAmount)
                .ToList();

            // Додати дані категорій у вигляді кругової діаграми
            foreach (var expenseCategory in expenseCategories)
            {
                double percentage = (double)(expenseCategory.TotalAmount / totalExpense) * 100;

                // Додати серію на діаграму
                pieChart1.Series.Add(new PieSeries
                {
                    Title = $"{expenseCategory.Category} ({percentage:F2}%)",
                    Values = new ChartValues<decimal> { expenseCategory.TotalAmount },
                    DataLabels = true
                });
            }
        }


    }


}
