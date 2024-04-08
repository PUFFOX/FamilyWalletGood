using OfficeOpenXml;
using System;
using System.Collections;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WFGunaFamilyWallet.ChildForm;
using WFGunaFamilyWallet.Controls;
using WFGunaFamilyWallet.models;

namespace WFGunaFamilyWallet
{
    // Головна форма програми
    public partial class MainForm : Form
    {
        // Контекст бази даних
        private BudgetContext dbContext = new BudgetContext();
        public UCTransactions TransactionsForm { get; set; }

        // Останній вибраний контроль
        private Control lastSelectedControl;

        // Ім'я ввійшовшого користувача
        private string loggedInUsername;

        // Напрямок сортування для ListView
        private SortOrder listViewSortOrder = SortOrder.None;

        // Індекс стовпця, за яким відбувається сортування
        private int listViewSortColumn = -1;

        // Контролери вкладок
        UCTransactions controlTransactions = new UCTransactions();
        UCStatistics controlStatistics = new UCStatistics();
        UCSettings controlSettings = new UCSettings();
        UCSupport controlSupport = new UCSupport();



        // Конструктор форми з параметром ім'я користувача
        public MainForm(string username)
        {

            InitializeComponent();
            loggedInUsername = username;
            controlTransactions.LoggedInUsername = loggedInUsername;
            SetUsernameLabel();

            labelTimeNow.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm dddd");
            lastSelectedControl = controlTransactions;


            if (listViewHistory.Columns.Count == 0)
            {
                listViewHistory.Columns.Add("№", 25);
                listViewHistory.Columns.Add("Дата", 75);
                listViewHistory.Columns.Add("Тип", 65);
                listViewHistory.Columns.Add("Категорія", 110);
                listViewHistory.Columns.Add("Сума", 71);
                listViewHistory.Columns.Add("Користувач", 70);
                listViewHistory.Columns.Add("Коментар", 160);
            }


            listViewHistory.ColumnClick += ListViewHistory_ColumnClick;

            UpdateListView();

        }



        private void ListViewHistory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Змінюємо напрямок сортування, якщо клік відбувся на тому самому стовпці
            if (e.Column == listViewSortColumn)
            {
                listViewSortOrder = (listViewSortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Ініціалізуємо сортування для нового стовпця
                listViewSortColumn = e.Column;
                listViewSortOrder = SortOrder.Ascending;
            }

            // Сортуємо ListView за новими параметрами
            SortListView((ListView)sender, e.Column);
            UpdateListView();
        }

        private void SortListView(ListView listView, int columnIndex)
        {
            listView.ListViewItemSorter = new ListViewItemComparer(columnIndex, listViewSortOrder);
            listView.Sort();
        }

        // Встановлення тексту для лейбла з іменем користувача
        private void SetUsernameLabel()
        {
            lblUsername.Text = loggedInUsername;
        }

        private void UpdateListView()
        {
            try
            {
                //чистка перед додаванням нових елементів.
                listViewHistory.Items.Clear();

                //дані транзакцій з бази даних
                var transactions = dbContext.Transactions
                    .Include(t => t.User)
                    .Include(t => t.Category)
                    .Include(t => t.Description)
                    .ToList();

                foreach (var transaction in transactions)
                {
                    var item = new ListViewItem(transaction.Id.ToString());

                    // колір в залежності від типу транзакції
                    Color rowColor = transaction.Type == Transaction.TransactionType.Income
                        ? Color.LightGreen
                        : Color.LightCoral;

                    // Заповнення фону рядка
                    using (var brush = new SolidBrush(rowColor))
                    {
                        item.BackColor = rowColor;
                    }

                    item.SubItems.Add(transaction.DateTime.ToShortDateString());
                    item.SubItems.Add(transaction.Type.ToString());
                    item.SubItems.Add(transaction.Category?.NameCategory ?? "");
                    item.SubItems.Add(transaction.Amount.ToString());
                    item.SubItems.Add(transaction.User?.Username ?? "");
                    item.SubItems.Add(transaction.Description?.Comment ?? "");

                    listViewHistory.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні ListView: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadControl(Control control)
        {
            UpdateListView();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            lastSelectedControl = control;
            controlTransactions.UpdateBase();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (listViewHistory.SelectedItems.Count > 0)
            {
                // Отримайте ідентифікатор обраної транзакції з першого обраного елемента
                int selectedTransactionId = int.Parse(listViewHistory.SelectedItems[0].Text);

                // Отримайте відповідну транзакцію з бази даних
                var transactionToDelete = dbContext.Transactions.FirstOrDefault(t => t.Id == selectedTransactionId);

                // Перевірте, чи користувач, який видаляє транзакцію, співпадає з вхідним користувачем
                if (transactionToDelete != null && transactionToDelete.User.Username == loggedInUsername)
                {
                    // Запитайте користувача для підтвердження видалення
                    DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити транзакцію ID {selectedTransactionId}?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Видаліть транзакцію з бази даних
                            dbContext.Transactions.Remove(transactionToDelete);
                            dbContext.SaveChanges();

                            MessageBox.Show("Транзакція видалена.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateListView();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Помилка при видаленні транзакції: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ви можете видаляти лише свої транзакції.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть транзакцію для видалення.", "Транзакція не обрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            using (var addFormUser = new AddFormUser())
            {
                if (addFormUser.ShowDialog() == DialogResult.OK)
                {
                    string newUser = addFormUser.NewUser;
                }
            }
            this.Close();
        }

        private void menuBtnSettings_Click(object sender, EventArgs e)
        {
            LoadControl(controlSettings);
        }

        private void menuBtnSupport_Click(object sender, EventArgs e)
        {
            LoadControl(controlSupport);
        }

        private void menuBtnStatistics_Click(object sender, EventArgs e)
        {
            LoadControl(controlStatistics);
        }

        private void menuBtnTransaction_Click(object sender, EventArgs e)
        {
            LoadControl(controlTransactions);
        }

        private void menuBtnHistory_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(listViewHistory);
            mainPanel.Controls.Add(btnExcel);
            mainPanel.Controls.Add(bntDelete);
            UpdateListView();
        }

        private void btnMainReset_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            menuBtnHistory.PerformClick();
            UpdateListView();
            controlTransactions.UpdateBase();
        }


        public void ExportToExcel()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (var package = new ExcelPackage())
                        {
                            var workSheet = package.Workbook.Worksheets.Add("Transactions");

                            // Додавання заголовків стовпців
                            for (int i = 1; i <= listViewHistory.Columns.Count; i++)
                            {
                                workSheet.Cells[1, i].Value = listViewHistory.Columns[i - 1].Text;
                            }

                            // Додавання даних
                            for (int i = 0; i < listViewHistory.Items.Count; i++)
                            {
                                for (int j = 0; j < listViewHistory.Columns.Count; j++)
                                {
                                    workSheet.Cells[i + 2, j + 1].Value = listViewHistory.Items[i].SubItems[j].Text;
                                }
                            }

                            package.SaveAs(new FileInfo(filePath));
                            MessageBox.Show("Базу даних успішно збережено у форматі Excel.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні бази даних у форматі Excel: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }

    // Клас для порівняння елементів ListView для сортування
    public class ListViewItemComparer : IComparer
    {
        private int columnIndex;
        private SortOrder sortOrder;

        public ListViewItemComparer(int columnIndex, SortOrder sortOrder)
        {
            this.columnIndex = columnIndex;
            this.sortOrder = sortOrder;
        }

        public int Compare(object x, object y)
        {
            ListViewItem listViewItemX = (ListViewItem)x;
            ListViewItem listViewItemY = (ListViewItem)y;
            string xText = listViewItemX.SubItems[columnIndex].Text;
            string yText = listViewItemY.SubItems[columnIndex].Text;
            int compareResult = string.Compare(xText, yText);
            if (sortOrder == SortOrder.Ascending)
            {
                return compareResult;
            }
            else
            {
                return -compareResult;
            }
        }






    }
}
