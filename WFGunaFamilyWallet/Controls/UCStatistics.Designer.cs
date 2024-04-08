namespace WFGunaFamilyWallet.Controls
{
    partial class UCStatistics
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelStatistics = new Guna.UI.WinForms.GunaGradient2Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.labelTotalIncome = new Guna.UI.WinForms.GunaTextBox();
            this.cmbAllIncomesStatistics = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.labelTotalExpense = new Guna.UI.WinForms.GunaTextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.cmbAllExpensesStatistics = new System.Windows.Forms.ComboBox();
            this.tabExpensesCategories = new System.Windows.Forms.TabPage();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.labelCategoryExpenses = new Guna.UI.WinForms.GunaTextBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.PanelStatistics.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabIncome.SuspendLayout();
            this.tabExpenses.SuspendLayout();
            this.tabExpensesCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStatistics
            // 
            this.PanelStatistics.BackColor = System.Drawing.Color.Transparent;
            this.PanelStatistics.Controls.Add(this.tabControl1);
            this.PanelStatistics.Controls.Add(this.gunaSeparator1);
            this.PanelStatistics.Controls.Add(this.gunaLabel1);
            this.PanelStatistics.GradientColor1 = System.Drawing.Color.Purple;
            this.PanelStatistics.GradientColor2 = System.Drawing.Color.CornflowerBlue;
            this.PanelStatistics.Location = new System.Drawing.Point(2, 2);
            this.PanelStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.PanelStatistics.Name = "PanelStatistics";
            this.PanelStatistics.Size = new System.Drawing.Size(588, 464);
            this.PanelStatistics.TabIndex = 31;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIncome);
            this.tabControl1.Controls.Add(this.tabExpenses);
            this.tabControl1.Controls.Add(this.tabExpensesCategories);
            this.tabControl1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 416);
            this.tabControl1.TabIndex = 37;
            // 
            // tabIncome
            // 
            this.tabIncome.BackColor = System.Drawing.Color.Purple;
            this.tabIncome.Controls.Add(this.cartesianChart1);
            this.tabIncome.Controls.Add(this.labelTotalIncome);
            this.tabIncome.Controls.Add(this.cmbAllIncomesStatistics);
            this.tabIncome.Controls.Add(this.listView1);
            this.tabIncome.Location = new System.Drawing.Point(4, 26);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncome.Size = new System.Drawing.Size(574, 386);
            this.tabIncome.TabIndex = 0;
            this.tabIncome.Text = "Доходи";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(6, 233);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(561, 100);
            this.cartesianChart1.TabIndex = 37;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTotalIncome.BorderColor = System.Drawing.Color.Purple;
            this.labelTotalIncome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelTotalIncome.FocusedBaseColor = System.Drawing.Color.White;
            this.labelTotalIncome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.labelTotalIncome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTotalIncome.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalIncome.ForeColor = System.Drawing.Color.Purple;
            this.labelTotalIncome.Location = new System.Drawing.Point(0, 349);
            this.labelTotalIncome.Margin = new System.Windows.Forms.Padding(2);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.PasswordChar = '\0';
            this.labelTotalIncome.SelectedText = "";
            this.labelTotalIncome.Size = new System.Drawing.Size(574, 35);
            this.labelTotalIncome.TabIndex = 36;
            this.labelTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbAllIncomesStatistics
            // 
            this.cmbAllIncomesStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbAllIncomesStatistics.FormattingEnabled = true;
            this.cmbAllIncomesStatistics.Location = new System.Drawing.Point(3, 6);
            this.cmbAllIncomesStatistics.Name = "cmbAllIncomesStatistics";
            this.cmbAllIncomesStatistics.Size = new System.Drawing.Size(140, 25);
            this.cmbAllIncomesStatistics.TabIndex = 33;
            this.cmbAllIncomesStatistics.Enter += new System.EventHandler(this.cmbAllIncomesStatistics_Enter);
            this.cmbAllIncomesStatistics.Leave += new System.EventHandler(this.cmbAllIncomesStatistics_Leave);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.Purple;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 193);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabExpenses
            // 
            this.tabExpenses.BackColor = System.Drawing.Color.Purple;
            this.tabExpenses.Controls.Add(this.cartesianChart2);
            this.tabExpenses.Controls.Add(this.labelTotalExpense);
            this.tabExpenses.Controls.Add(this.listView2);
            this.tabExpenses.Controls.Add(this.cmbAllExpensesStatistics);
            this.tabExpenses.Location = new System.Drawing.Point(4, 26);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenses.Size = new System.Drawing.Size(574, 386);
            this.tabExpenses.TabIndex = 1;
            this.tabExpenses.Text = "Витрати";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(6, 246);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(561, 100);
            this.cartesianChart2.TabIndex = 41;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // labelTotalExpense
            // 
            this.labelTotalExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalExpense.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTotalExpense.BorderColor = System.Drawing.Color.Purple;
            this.labelTotalExpense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelTotalExpense.FocusedBaseColor = System.Drawing.Color.White;
            this.labelTotalExpense.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.labelTotalExpense.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTotalExpense.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalExpense.ForeColor = System.Drawing.Color.Purple;
            this.labelTotalExpense.Location = new System.Drawing.Point(0, 351);
            this.labelTotalExpense.Margin = new System.Windows.Forms.Padding(2);
            this.labelTotalExpense.Name = "labelTotalExpense";
            this.labelTotalExpense.PasswordChar = '\0';
            this.labelTotalExpense.SelectedText = "";
            this.labelTotalExpense.Size = new System.Drawing.Size(574, 35);
            this.labelTotalExpense.TabIndex = 40;
            this.labelTotalExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView2.ForeColor = System.Drawing.Color.Purple;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(2, 35);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(570, 177);
            this.listView2.TabIndex = 38;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // cmbAllExpensesStatistics
            // 
            this.cmbAllExpensesStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbAllExpensesStatistics.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAllExpensesStatistics.FormattingEnabled = true;
            this.cmbAllExpensesStatistics.Location = new System.Drawing.Point(3, 6);
            this.cmbAllExpensesStatistics.Name = "cmbAllExpensesStatistics";
            this.cmbAllExpensesStatistics.Size = new System.Drawing.Size(140, 25);
            this.cmbAllExpensesStatistics.TabIndex = 37;
            this.cmbAllExpensesStatistics.Enter += new System.EventHandler(this.cmbAllExpensesStatistics_Enter);
            this.cmbAllExpensesStatistics.Leave += new System.EventHandler(this.cmbAllExpensesStatistics_Leave);
            // 
            // tabExpensesCategories
            // 
            this.tabExpensesCategories.BackColor = System.Drawing.Color.Purple;
            this.tabExpensesCategories.Controls.Add(this.cmbMonth);
            this.tabExpensesCategories.Controls.Add(this.labelCategoryExpenses);
            this.tabExpensesCategories.Controls.Add(this.listView3);
            this.tabExpensesCategories.Controls.Add(this.pieChart1);
            this.tabExpensesCategories.Location = new System.Drawing.Point(4, 26);
            this.tabExpensesCategories.Name = "tabExpensesCategories";
            this.tabExpensesCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpensesCategories.Size = new System.Drawing.Size(574, 386);
            this.tabExpensesCategories.TabIndex = 5;
            this.tabExpensesCategories.Text = "Витрати за категоріями";
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbMonth.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(7, 15);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(140, 25);
            this.cmbMonth.TabIndex = 42;
            // 
            // labelCategoryExpenses
            // 
            this.labelCategoryExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategoryExpenses.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelCategoryExpenses.BorderColor = System.Drawing.Color.Purple;
            this.labelCategoryExpenses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelCategoryExpenses.FocusedBaseColor = System.Drawing.Color.White;
            this.labelCategoryExpenses.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.labelCategoryExpenses.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCategoryExpenses.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategoryExpenses.ForeColor = System.Drawing.Color.Purple;
            this.labelCategoryExpenses.Location = new System.Drawing.Point(2, 351);
            this.labelCategoryExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.labelCategoryExpenses.Name = "labelCategoryExpenses";
            this.labelCategoryExpenses.PasswordChar = '\0';
            this.labelCategoryExpenses.SelectedText = "";
            this.labelCategoryExpenses.Size = new System.Drawing.Size(572, 35);
            this.labelCategoryExpenses.TabIndex = 41;
            this.labelCategoryExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView3.ForeColor = System.Drawing.Color.Purple;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(7, 46);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(232, 300);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(245, 6);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(323, 340);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(3, 30);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(576, 10);
            this.gunaSeparator1.TabIndex = 32;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaLabel1.Location = new System.Drawing.Point(9, 0);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Статистика";
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // UCStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelStatistics);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCStatistics";
            this.Size = new System.Drawing.Size(592, 467);
            this.Load += new System.EventHandler(this.UCStatistics_Load);
            this.PanelStatistics.ResumeLayout(false);
            this.PanelStatistics.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabIncome.ResumeLayout(false);
            this.tabExpenses.ResumeLayout(false);
            this.tabExpensesCategories.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradient2Panel PanelStatistics;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;


        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIncome;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Guna.UI.WinForms.GunaTextBox labelTotalIncome;
        private System.Windows.Forms.ComboBox cmbAllIncomesStatistics;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabExpenses;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private Guna.UI.WinForms.GunaTextBox labelTotalExpense;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ComboBox cmbAllExpensesStatistics;
        private System.Windows.Forms.TabPage tabExpensesCategories;
        private System.Windows.Forms.ComboBox cmbMonth;
        private Guna.UI.WinForms.GunaTextBox labelCategoryExpenses;
        private System.Windows.Forms.ListView listView3;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}
