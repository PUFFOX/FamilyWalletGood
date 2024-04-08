namespace WFGunaFamilyWallet
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.labelTimeNow = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btnLogout = new Guna.UI.WinForms.GunaGradientButton();
            this.menuBtnSupport = new Guna.UI.WinForms.GunaGradientButton();
            this.menuBtnSettings = new Guna.UI.WinForms.GunaGradientButton();
            this.menuBtnStatistics = new Guna.UI.WinForms.GunaGradientButton();
            this.menuBtnTransaction = new Guna.UI.WinForms.GunaGradientButton();
            this.menuBtnHistory = new Guna.UI.WinForms.GunaGradientButton();
            this.btnMainReset = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.mainPanel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.bntDelete = new Guna.UI.WinForms.GunaGradientButton();
            this.btnExcel = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaGradient2Panel2.SuspendLayout();
            this.gunaGradient2Panel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(10, 526);
            this.gunaSeparator2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(130, 14);
            this.gunaSeparator2.TabIndex = 10;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(10, 101);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(130, 10);
            this.gunaSeparator1.TabIndex = 2;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // labelTimeNow
            // 
            this.labelTimeNow.AutoSize = true;
            this.labelTimeNow.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeNow.Location = new System.Drawing.Point(397, 15);
            this.labelTimeNow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeNow.Name = "labelTimeNow";
            this.labelTimeNow.Size = new System.Drawing.Size(84, 18);
            this.labelTimeNow.TabIndex = 2;
            this.labelTimeNow.Text = "gunaLabel2";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Controls.Add(this.lblUsername);
            this.gunaGradient2Panel1.Controls.Add(this.pictureBox1);
            this.gunaGradient2Panel1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Purple;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.CornflowerBlue;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(164, 9);
            this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(592, 61);
            this.gunaGradient2Panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Домашній бюджет";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblUsername.Location = new System.Drawing.Point(437, 14);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 33);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WFGunaFamilyWallet.Properties.Resources.user_account_person_avatar_icon_131248;
            this.pictureBox1.Location = new System.Drawing.Point(400, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.btnLogout);
            this.gunaGradient2Panel2.Controls.Add(this.menuBtnSupport);
            this.gunaGradient2Panel2.Controls.Add(this.menuBtnSettings);
            this.gunaGradient2Panel2.Controls.Add(this.menuBtnStatistics);
            this.gunaGradient2Panel2.Controls.Add(this.menuBtnTransaction);
            this.gunaGradient2Panel2.Controls.Add(this.menuBtnHistory);
            this.gunaGradient2Panel2.Controls.Add(this.btnMainReset);
            this.gunaGradient2Panel2.Controls.Add(this.gunaSeparator2);
            this.gunaGradient2Panel2.Controls.Add(this.gunaSeparator1);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.CornflowerBlue;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.Purple;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(9, 9);
            this.gunaGradient2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(151, 583);
            this.gunaGradient2Panel2.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.BaseColor2 = System.Drawing.Color.Purple;
            this.btnLogout.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.Image = global::WFGunaFamilyWallet.Properties.Resources.logout2;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(2, 544);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor1 = System.Drawing.Color.Purple;
            this.btnLogout.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(146, 37);
            this.btnLogout.TabIndex = 79;
            this.btnLogout.Text = "Вихід";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuBtnSupport
            // 
            this.menuBtnSupport.AnimationHoverSpeed = 0.07F;
            this.menuBtnSupport.AnimationSpeed = 0.03F;
            this.menuBtnSupport.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnSupport.BaseColor2 = System.Drawing.Color.Purple;
            this.menuBtnSupport.BorderColor = System.Drawing.Color.DimGray;
            this.menuBtnSupport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuBtnSupport.FocusedColor = System.Drawing.Color.Empty;
            this.menuBtnSupport.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBtnSupport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuBtnSupport.Image = global::WFGunaFamilyWallet.Properties.Resources.support;
            this.menuBtnSupport.ImageSize = new System.Drawing.Size(20, 20);
            this.menuBtnSupport.Location = new System.Drawing.Point(2, 369);
            this.menuBtnSupport.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtnSupport.Name = "menuBtnSupport";
            this.menuBtnSupport.OnHoverBaseColor1 = System.Drawing.Color.Purple;
            this.menuBtnSupport.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnSupport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuBtnSupport.OnHoverForeColor = System.Drawing.Color.White;
            this.menuBtnSupport.OnHoverImage = null;
            this.menuBtnSupport.OnPressedColor = System.Drawing.Color.Black;
            this.menuBtnSupport.Size = new System.Drawing.Size(146, 37);
            this.menuBtnSupport.TabIndex = 78;
            this.menuBtnSupport.Text = "Підтримка";
            this.menuBtnSupport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menuBtnSupport.Click += new System.EventHandler(this.menuBtnSupport_Click);
            // 
            // menuBtnSettings
            // 
            this.menuBtnSettings.AnimationHoverSpeed = 0.07F;
            this.menuBtnSettings.AnimationSpeed = 0.03F;
            this.menuBtnSettings.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnSettings.BaseColor2 = System.Drawing.Color.Purple;
            this.menuBtnSettings.BorderColor = System.Drawing.Color.DimGray;
            this.menuBtnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuBtnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.menuBtnSettings.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuBtnSettings.Image = global::WFGunaFamilyWallet.Properties.Resources.setting2;
            this.menuBtnSettings.ImageSize = new System.Drawing.Size(20, 20);
            this.menuBtnSettings.Location = new System.Drawing.Point(2, 327);
            this.menuBtnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtnSettings.Name = "menuBtnSettings";
            this.menuBtnSettings.OnHoverBaseColor1 = System.Drawing.Color.Purple;
            this.menuBtnSettings.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnSettings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuBtnSettings.OnHoverForeColor = System.Drawing.Color.White;
            this.menuBtnSettings.OnHoverImage = null;
            this.menuBtnSettings.OnPressedColor = System.Drawing.Color.Black;
            this.menuBtnSettings.Size = new System.Drawing.Size(146, 37);
            this.menuBtnSettings.TabIndex = 77;
            this.menuBtnSettings.Text = "Налаштування";
            this.menuBtnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menuBtnSettings.Click += new System.EventHandler(this.menuBtnSettings_Click);
            // 
            // menuBtnStatistics
            // 
            this.menuBtnStatistics.AnimationHoverSpeed = 0.07F;
            this.menuBtnStatistics.AnimationSpeed = 0.03F;
            this.menuBtnStatistics.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnStatistics.BaseColor2 = System.Drawing.Color.Purple;
            this.menuBtnStatistics.BorderColor = System.Drawing.Color.DimGray;
            this.menuBtnStatistics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuBtnStatistics.FocusedColor = System.Drawing.Color.Empty;
            this.menuBtnStatistics.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBtnStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuBtnStatistics.Image = global::WFGunaFamilyWallet.Properties.Resources.statistics;
            this.menuBtnStatistics.ImageSize = new System.Drawing.Size(20, 20);
            this.menuBtnStatistics.Location = new System.Drawing.Point(2, 286);
            this.menuBtnStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtnStatistics.Name = "menuBtnStatistics";
            this.menuBtnStatistics.OnHoverBaseColor1 = System.Drawing.Color.Purple;
            this.menuBtnStatistics.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnStatistics.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuBtnStatistics.OnHoverForeColor = System.Drawing.Color.White;
            this.menuBtnStatistics.OnHoverImage = null;
            this.menuBtnStatistics.OnPressedColor = System.Drawing.Color.Black;
            this.menuBtnStatistics.Size = new System.Drawing.Size(146, 37);
            this.menuBtnStatistics.TabIndex = 76;
            this.menuBtnStatistics.Text = "Статистика";
            this.menuBtnStatistics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menuBtnStatistics.Click += new System.EventHandler(this.menuBtnStatistics_Click);
            // 
            // menuBtnTransaction
            // 
            this.menuBtnTransaction.AnimationHoverSpeed = 0.07F;
            this.menuBtnTransaction.AnimationSpeed = 0.03F;
            this.menuBtnTransaction.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnTransaction.BaseColor2 = System.Drawing.Color.Purple;
            this.menuBtnTransaction.BorderColor = System.Drawing.Color.DimGray;
            this.menuBtnTransaction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuBtnTransaction.FocusedColor = System.Drawing.Color.Empty;
            this.menuBtnTransaction.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBtnTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuBtnTransaction.Image = global::WFGunaFamilyWallet.Properties.Resources.transaction;
            this.menuBtnTransaction.ImageSize = new System.Drawing.Size(20, 20);
            this.menuBtnTransaction.Location = new System.Drawing.Point(2, 245);
            this.menuBtnTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtnTransaction.Name = "menuBtnTransaction";
            this.menuBtnTransaction.OnHoverBaseColor1 = System.Drawing.Color.Purple;
            this.menuBtnTransaction.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnTransaction.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuBtnTransaction.OnHoverForeColor = System.Drawing.Color.White;
            this.menuBtnTransaction.OnHoverImage = null;
            this.menuBtnTransaction.OnPressedColor = System.Drawing.Color.Black;
            this.menuBtnTransaction.Size = new System.Drawing.Size(146, 37);
            this.menuBtnTransaction.TabIndex = 75;
            this.menuBtnTransaction.Text = "Транзакції";
            this.menuBtnTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menuBtnTransaction.Click += new System.EventHandler(this.menuBtnTransaction_Click);
            // 
            // menuBtnHistory
            // 
            this.menuBtnHistory.AnimationHoverSpeed = 0.07F;
            this.menuBtnHistory.AnimationSpeed = 0.03F;
            this.menuBtnHistory.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnHistory.BaseColor2 = System.Drawing.Color.Purple;
            this.menuBtnHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuBtnHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.menuBtnHistory.FocusedColor = System.Drawing.Color.Empty;
            this.menuBtnHistory.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBtnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuBtnHistory.Image = global::WFGunaFamilyWallet.Properties.Resources.history;
            this.menuBtnHistory.ImageSize = new System.Drawing.Size(20, 20);
            this.menuBtnHistory.Location = new System.Drawing.Point(2, 203);
            this.menuBtnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtnHistory.Name = "menuBtnHistory";
            this.menuBtnHistory.OnHoverBaseColor1 = System.Drawing.Color.Purple;
            this.menuBtnHistory.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuBtnHistory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.menuBtnHistory.OnHoverForeColor = System.Drawing.Color.White;
            this.menuBtnHistory.OnHoverImage = null;
            this.menuBtnHistory.OnPressedColor = System.Drawing.Color.Black;
            this.menuBtnHistory.Size = new System.Drawing.Size(146, 37);
            this.menuBtnHistory.TabIndex = 74;
            this.menuBtnHistory.Text = "Історія";
            this.menuBtnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.menuBtnHistory.Click += new System.EventHandler(this.menuBtnHistory_Click);
            // 
            // btnMainReset
            // 
            this.btnMainReset.AnimationHoverSpeed = 0.07F;
            this.btnMainReset.AnimationSpeed = 0.03F;
            this.btnMainReset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMainReset.BorderColor = System.Drawing.Color.Black;
            this.btnMainReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMainReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnMainReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMainReset.ForeColor = System.Drawing.Color.White;
            this.btnMainReset.Image = global::WFGunaFamilyWallet.Properties.Resources.wallet4;
            this.btnMainReset.ImageSize = new System.Drawing.Size(80, 80);
            this.btnMainReset.Location = new System.Drawing.Point(24, 3);
            this.btnMainReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainReset.Name = "btnMainReset";
            this.btnMainReset.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnMainReset.OnHoverBorderColor = System.Drawing.Color.Purple;
            this.btnMainReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMainReset.OnHoverImage = null;
            this.btnMainReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnMainReset.Size = new System.Drawing.Size(106, 94);
            this.btnMainReset.TabIndex = 0;
            this.btnMainReset.Click += new System.EventHandler(this.btnMainReset_Click);
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.labelTimeNow);
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.Purple;
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(164, 544);
            this.gunaGradient2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(592, 47);
            this.gunaGradient2Panel3.TabIndex = 6;
            // 
            // listViewHistory
            // 
            this.listViewHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listViewHistory.BackColor = System.Drawing.Color.Plum;
            this.listViewHistory.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewHistory.HideSelection = false;
            this.listViewHistory.Location = new System.Drawing.Point(3, 3);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(588, 420);
            this.listViewHistory.TabIndex = 3;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.bntDelete);
            this.mainPanel.Controls.Add(this.btnExcel);
            this.mainPanel.Controls.Add(this.listViewHistory);
            this.mainPanel.GradientColor1 = System.Drawing.Color.Purple;
            this.mainPanel.GradientColor2 = System.Drawing.Color.CornflowerBlue;
            this.mainPanel.Location = new System.Drawing.Point(164, 73);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(592, 467);
            this.mainPanel.TabIndex = 5;
            // 
            // bntDelete
            // 
            this.bntDelete.AnimationHoverSpeed = 0.07F;
            this.bntDelete.AnimationSpeed = 0.03F;
            this.bntDelete.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntDelete.BaseColor2 = System.Drawing.Color.Purple;
            this.bntDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntDelete.FocusedColor = System.Drawing.Color.Empty;
            this.bntDelete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bntDelete.Image = global::WFGunaFamilyWallet.Properties.Resources.delete;
            this.bntDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.bntDelete.Location = new System.Drawing.Point(443, 428);
            this.bntDelete.Margin = new System.Windows.Forms.Padding(2);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.OnHoverBaseColor1 = System.Drawing.Color.Purple;
            this.bntDelete.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bntDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.bntDelete.OnHoverImage = null;
            this.bntDelete.OnPressedColor = System.Drawing.Color.Black;
            this.bntDelete.Size = new System.Drawing.Size(146, 37);
            this.bntDelete.TabIndex = 81;
            this.bntDelete.Text = "Видалити";
            this.bntDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.AnimationHoverSpeed = 0.07F;
            this.btnExcel.AnimationSpeed = 0.03F;
            this.btnExcel.BaseColor1 = System.Drawing.Color.Purple;
            this.btnExcel.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExcel.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcel.FocusedColor = System.Drawing.Color.Empty;
            this.btnExcel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExcel.Image = global::WFGunaFamilyWallet.Properties.Resources.budget;
            this.btnExcel.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExcel.Location = new System.Drawing.Point(3, 428);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnExcel.OnHoverBaseColor2 = System.Drawing.Color.Purple;
            this.btnExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExcel.OnHoverImage = null;
            this.btnExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExcel.Size = new System.Drawing.Size(146, 37);
            this.btnExcel.TabIndex = 80;
            this.btnExcel.Text = "В Excel";
            this.btnExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(766, 600);
            this.Controls.Add(this.gunaGradient2Panel3);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel3.ResumeLayout(false);
            this.gunaGradient2Panel3.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaCircleButton btnMainReset;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel labelTimeNow;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradient2Panel mainPanel;
        private System.Windows.Forms.ListView listViewHistory;
        private Guna.UI.WinForms.GunaGradientButton menuBtnHistory;
        private Guna.UI.WinForms.GunaGradientButton menuBtnTransaction;
        private Guna.UI.WinForms.GunaGradientButton menuBtnStatistics;
        private Guna.UI.WinForms.GunaGradientButton menuBtnSettings;
        private Guna.UI.WinForms.GunaGradientButton menuBtnSupport;
        private Guna.UI.WinForms.GunaGradientButton btnLogout;
        private Guna.UI.WinForms.GunaGradientButton btnExcel;
        private Guna.UI.WinForms.GunaGradientButton bntDelete;
        private System.Windows.Forms.Label label1;
    }
}

