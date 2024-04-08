namespace WFGunaFamilyWallet.Controls
{
    partial class UCTransactions
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
            this.PanelTransaction = new Guna.UI.WinForms.GunaGradient2Panel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.labTrans = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.rbtnExpense = new Guna.UI.WinForms.GunaRadioButton();
            this.rbtnIncome = new Guna.UI.WinForms.GunaRadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtComm = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveTransaction = new Guna.UI.WinForms.GunaGradientButton();
            this.PanelTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTransaction
            // 
            this.PanelTransaction.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransaction.Controls.Add(this.btnSaveTransaction);
            this.PanelTransaction.Controls.Add(this.txtComment);
            this.PanelTransaction.Controls.Add(this.txtAmount);
            this.PanelTransaction.Controls.Add(this.cmbCategories);
            this.PanelTransaction.Controls.Add(this.cmbUsers);
            this.PanelTransaction.Controls.Add(this.labTrans);
            this.PanelTransaction.Controls.Add(this.gunaSeparator1);
            this.PanelTransaction.Controls.Add(this.gunaSeparator2);
            this.PanelTransaction.Controls.Add(this.gunaLabel3);
            this.PanelTransaction.Controls.Add(this.gunaLabel6);
            this.PanelTransaction.Controls.Add(this.rbtnExpense);
            this.PanelTransaction.Controls.Add(this.rbtnIncome);
            this.PanelTransaction.Controls.Add(this.dateTimePicker);
            this.PanelTransaction.Controls.Add(this.gunaLabel5);
            this.PanelTransaction.Controls.Add(this.txtComm);
            this.PanelTransaction.Controls.Add(this.gunaLabel2);
            this.PanelTransaction.Controls.Add(this.gunaLabel4);
            this.PanelTransaction.Controls.Add(this.gunaLabel1);
            this.PanelTransaction.GradientColor1 = System.Drawing.Color.Purple;
            this.PanelTransaction.GradientColor2 = System.Drawing.Color.CornflowerBlue;
            this.PanelTransaction.Location = new System.Drawing.Point(2, 2);
            this.PanelTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTransaction.Name = "PanelTransaction";
            this.PanelTransaction.Size = new System.Drawing.Size(587, 464);
            this.PanelTransaction.TabIndex = 30;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtComment.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComment.ForeColor = System.Drawing.Color.Purple;
            this.txtComment.Location = new System.Drawing.Point(132, 241);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(186, 23);
            this.txtComment.TabIndex = 70;
            this.txtComment.UseSystemPasswordChar = true;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmount.ForeColor = System.Drawing.Color.Purple;
            this.txtAmount.Location = new System.Drawing.Point(132, 195);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(186, 23);
            this.txtAmount.TabIndex = 69;
            this.txtAmount.UseSystemPasswordChar = true;
            // 
            // cmbCategories
            // 
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbCategories.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCategories.ForeColor = System.Drawing.Color.Purple;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(132, 148);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(186, 24);
            this.cmbCategories.TabIndex = 68;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            this.cmbCategories.Enter += new System.EventHandler(this.cmbCategories_Enter);
            this.cmbCategories.Leave += new System.EventHandler(this.cmbCategories_Leave);
            // 
            // cmbUsers
            // 
            this.cmbUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbUsers.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUsers.ForeColor = System.Drawing.Color.Purple;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(132, 102);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(186, 24);
            this.cmbUsers.TabIndex = 67;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            this.cmbUsers.Enter += new System.EventHandler(this.cmbUsers_Enter);
            this.cmbUsers.Leave += new System.EventHandler(this.cmbUsers_Leave);
            // 
            // labTrans
            // 
            this.labTrans.AutoSize = true;
            this.labTrans.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTrans.ForeColor = System.Drawing.Color.Purple;
            this.labTrans.Location = new System.Drawing.Point(513, 21);
            this.labTrans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTrans.Name = "labTrans";
            this.labTrans.Size = new System.Drawing.Size(0, 17);
            this.labTrans.TabIndex = 33;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(14, 41);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(566, 15);
            this.gunaSeparator1.TabIndex = 32;
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(14, 447);
            this.gunaSeparator2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(566, 15);
            this.gunaSeparator2.TabIndex = 31;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaLabel3.Location = new System.Drawing.Point(10, 58);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(55, 22);
            this.gunaLabel3.TabIndex = 27;
            this.gunaLabel3.Text = "Дата";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaLabel6.Location = new System.Drawing.Point(10, 301);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(135, 22);
            this.gunaLabel6.TabIndex = 19;
            this.gunaLabel6.Text = "Вид транзакції";
            // 
            // rbtnExpense
            // 
            this.rbtnExpense.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnExpense.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtnExpense.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtnExpense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnExpense.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnExpense.Location = new System.Drawing.Point(248, 301);
            this.rbtnExpense.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnExpense.Name = "rbtnExpense";
            this.rbtnExpense.Size = new System.Drawing.Size(103, 24);
            this.rbtnExpense.TabIndex = 18;
            this.rbtnExpense.Text = "Витрата";
            // 
            // rbtnIncome
            // 
            this.rbtnIncome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnIncome.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtnIncome.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbtnIncome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnIncome.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbtnIncome.Location = new System.Drawing.Point(161, 301);
            this.rbtnIncome.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnIncome.Name = "rbtnIncome";
            this.rbtnIncome.Size = new System.Drawing.Size(75, 24);
            this.rbtnIncome.TabIndex = 13;
            this.rbtnIncome.Text = "Дохід";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(132, 57);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(186, 23);
            this.dateTimePicker.TabIndex = 28;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaLabel5.Location = new System.Drawing.Point(10, 196);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(52, 22);
            this.gunaLabel5.TabIndex = 17;
            this.gunaLabel5.Text = "Сума";
            // 
            // txtComm
            // 
            this.txtComm.AutoSize = true;
            this.txtComm.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtComm.Location = new System.Drawing.Point(10, 241);
            this.txtComm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(95, 22);
            this.txtComm.TabIndex = 15;
            this.txtComm.Text = "Коментар";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaLabel2.Location = new System.Drawing.Point(9, 150);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Категорія";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaLabel4.Location = new System.Drawing.Point(10, 104);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(108, 22);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Користувач";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaLabel1.Location = new System.Drawing.Point(9, 9);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Транзакції";
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.AnimationHoverSpeed = 0.07F;
            this.btnSaveTransaction.AnimationSpeed = 0.03F;
            this.btnSaveTransaction.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveTransaction.BaseColor2 = System.Drawing.Color.Purple;
            this.btnSaveTransaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveTransaction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveTransaction.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveTransaction.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveTransaction.Image = global::WFGunaFamilyWallet.Properties.Resources.diskette;
            this.btnSaveTransaction.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSaveTransaction.Location = new System.Drawing.Point(434, 406);
            this.btnSaveTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.OnHoverBaseColor1 = System.Drawing.Color.CornflowerBlue;
            this.btnSaveTransaction.OnHoverBaseColor2 = System.Drawing.Color.Purple;
            this.btnSaveTransaction.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveTransaction.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveTransaction.OnHoverImage = null;
            this.btnSaveTransaction.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveTransaction.Size = new System.Drawing.Size(146, 37);
            this.btnSaveTransaction.TabIndex = 82;
            this.btnSaveTransaction.Text = "Зберігти";
            this.btnSaveTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click);
            // 
            // UCTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTransaction);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCTransactions";
            this.Size = new System.Drawing.Size(592, 467);
            this.PanelTransaction.ResumeLayout(false);
            this.PanelTransaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel PanelTransaction;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaRadioButton rbtnExpense;
        private Guna.UI.WinForms.GunaRadioButton rbtnIncome;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel txtComm;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel labTrans;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaGradientButton btnSaveTransaction;
    }
}
