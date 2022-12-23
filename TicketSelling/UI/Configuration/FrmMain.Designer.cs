namespace TicketSelling.UI.Configuration
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelleft = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnlogout = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnTicket = new FontAwesome.Sharp.IconButton();
            this.panelEntry = new System.Windows.Forms.Panel();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnEntry = new FontAwesome.Sharp.IconButton();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.btnMovie = new FontAwesome.Sharp.IconButton();
            this.btnSeat = new FontAwesome.Sharp.IconButton();
            this.btnConfiguration = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelAccountShow = new Guna.UI2.WinForms.Guna2Panel();
            this.accountimage = new FontAwesome.Sharp.IconButton();
            this.txtLoginNameForMain = new System.Windows.Forms.Label();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
            this.paneltitlebar = new Guna.UI2.WinForms.Guna2Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.toolTipConfiguration = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSeat = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdmin = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEntry = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMovie = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReport = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStaffs = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTicket = new System.Windows.Forms.ToolTip(this.components);
            this.panelleft.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelEntry.SuspendLayout();
            this.panelConfiguration.SuspendLayout();
            this.panelMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelAccountShow.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelleft.Controls.Add(this.panelMenu);
            this.panelleft.Controls.Add(this.panelMenuBar);
            resources.ApplyResources(this.panelleft, "panelleft");
            this.panelleft.Name = "panelleft";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnlogout);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnTicket);
            this.panelMenu.Controls.Add(this.panelEntry);
            this.panelMenu.Controls.Add(this.panelConfiguration);
            this.panelMenu.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnlogout
            // 
            resources.ApplyResources(this.btnlogout, "btnlogout");
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnlogout.IconColor = System.Drawing.Color.White;
            this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Tag = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            this.btnlogout.MouseHover += new System.EventHandler(this.Btnlogout_MouseHover);
            // 
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReport.IconColor = System.Drawing.Color.White;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.Name = "btnReport";
            this.btnReport.Tag = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            this.btnReport.MouseHover += new System.EventHandler(this.BtnReport_MouseHover);
            // 
            // btnTicket
            // 
            resources.ApplyResources(this.btnTicket, "btnTicket");
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btnTicket.IconColor = System.Drawing.Color.White;
            this.btnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Tag = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            this.btnTicket.MouseHover += new System.EventHandler(this.BtnTicket_MouseHover);
            // 
            // panelEntry
            // 
            this.panelEntry.Controls.Add(this.btnStaff);
            this.panelEntry.Controls.Add(this.btnAdmin);
            this.panelEntry.Controls.Add(this.btnEntry);
            resources.ApplyResources(this.panelEntry, "panelEntry");
            this.panelEntry.Name = "panelEntry";
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            resources.ApplyResources(this.btnStaff, "btnStaff");
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnStaff.IconColor = System.Drawing.Color.White;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.TabStop = false;
            this.btnStaff.Tag = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.TabStop = false;
            this.btnAdmin.Tag = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnEntry
            // 
            resources.ApplyResources(this.btnEntry, "btnEntry");
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            this.btnEntry.IconColor = System.Drawing.Color.White;
            this.btnEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.TabStop = false;
            this.btnEntry.Tag = "Entry";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            this.btnEntry.MouseHover += new System.EventHandler(this.BtnEntry_MouseHover);
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Controls.Add(this.btnMovie);
            this.panelConfiguration.Controls.Add(this.btnSeat);
            this.panelConfiguration.Controls.Add(this.btnConfiguration);
            resources.ApplyResources(this.panelConfiguration, "panelConfiguration");
            this.panelConfiguration.Name = "panelConfiguration";
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            resources.ApplyResources(this.btnMovie, "btnMovie");
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnMovie.IconColor = System.Drawing.Color.White;
            this.btnMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Tag = "Movie";
            this.btnMovie.UseVisualStyleBackColor = false;
            this.btnMovie.Click += new System.EventHandler(this.BtnMovie_Click);
            this.btnMovie.MouseHover += new System.EventHandler(this.BtnMovie_MouseHover);
            // 
            // btnSeat
            // 
            this.btnSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            resources.ApplyResources(this.btnSeat, "btnSeat");
            this.btnSeat.FlatAppearance.BorderSize = 0;
            this.btnSeat.ForeColor = System.Drawing.Color.White;
            this.btnSeat.IconChar = FontAwesome.Sharp.IconChar.Couch;
            this.btnSeat.IconColor = System.Drawing.Color.White;
            this.btnSeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeat.Name = "btnSeat";
            this.btnSeat.Tag = "Seat";
            this.btnSeat.UseVisualStyleBackColor = false;
            this.btnSeat.Click += new System.EventHandler(this.BtnSeat_Click);
            this.btnSeat.MouseHover += new System.EventHandler(this.BtnSeat_MouseHover);
            // 
            // btnConfiguration
            // 
            resources.ApplyResources(this.btnConfiguration, "btnConfiguration");
            this.btnConfiguration.FlatAppearance.BorderSize = 0;
            this.btnConfiguration.ForeColor = System.Drawing.Color.White;
            this.btnConfiguration.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btnConfiguration.IconColor = System.Drawing.Color.White;
            this.btnConfiguration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Tag = "Configuration";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.BtnConfiguration_Click);
            this.btnConfiguration.MouseHover += new System.EventHandler(this.BtnConfiguration_MouseHover);
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Name = "btnHome";
            this.btnHome.Tag = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.btnHome.MouseHover += new System.EventHandler(this.BtnHome_MouseHover);
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelMenuBar.Controls.Add(this.btnMenu);
            this.panelMenuBar.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelMenuBar, "panelMenuBar");
            this.panelMenuBar.Name = "panelMenuBar";
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::TicketSelling.Properties.Resources.Menu_512px;
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnMenu.MouseHover += new System.EventHandler(this.BtnMenu_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketSelling.Properties.Resources.welcome_cinema_neon_sign_popcorn_260nw_1178142151;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.panelAccountShow);
            this.panelTitle.Controls.Add(this.btnAccount);
            this.panelTitle.Controls.Add(this.btnSetting);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnExit);
            resources.ApplyResources(this.panelTitle, "panelTitle");
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // panelAccountShow
            // 
            resources.ApplyResources(this.panelAccountShow, "panelAccountShow");
            this.panelAccountShow.BackColor = System.Drawing.Color.Transparent;
            this.panelAccountShow.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelAccountShow.BorderThickness = 2;
            this.panelAccountShow.Controls.Add(this.accountimage);
            this.panelAccountShow.Controls.Add(this.txtLoginNameForMain);
            this.panelAccountShow.Name = "panelAccountShow";
            this.panelAccountShow.Tag = "AS";
            this.panelAccountShow.UseTransparentBackground = true;
            // 
            // accountimage
            // 
            this.accountimage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.accountimage, "accountimage");
            this.accountimage.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.accountimage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.accountimage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accountimage.IconSize = 60;
            this.accountimage.Name = "accountimage";
            this.accountimage.UseVisualStyleBackColor = true;
            // 
            // txtLoginNameForMain
            // 
            this.txtLoginNameForMain.AllowDrop = true;
            resources.ApplyResources(this.txtLoginNameForMain, "txtLoginNameForMain");
            this.txtLoginNameForMain.AutoEllipsis = true;
            this.txtLoginNameForMain.ForeColor = System.Drawing.Color.Black;
            this.txtLoginNameForMain.Name = "txtLoginNameForMain";
            // 
            // btnAccount
            // 
            resources.ApplyResources(this.btnAccount, "btnAccount");
            this.btnAccount.AutoEllipsis = true;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnAccount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Tag = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // btnSetting
            // 
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.AutoEllipsis = true;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.Gray;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Tag = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(182)))), ((int)(((byte)(211)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnMaximize
            // 
            resources.ApplyResources(this.btnMaximize, "btnMaximize");
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // toolTipHome
            // 
            this.toolTipHome.AutomaticDelay = 100;
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.paneltitlebar.Controls.Add(this.iconCurrentChildForm);
            this.paneltitlebar.Controls.Add(this.lblTitleChildForm);
            resources.ApplyResources(this.paneltitlebar, "paneltitlebar");
            this.paneltitlebar.Name = "paneltitlebar";
            // 
            // iconCurrentChildForm
            // 
            resources.ApplyResources(this.iconCurrentChildForm, "iconCurrentChildForm");
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // lblTitleChildForm
            // 
            resources.ApplyResources(this.lblTitleChildForm, "lblTitleChildForm");
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            // 
            // panelBody
            // 
            resources.ApplyResources(this.panelBody, "panelBody");
            this.panelBody.Name = "panelBody";
            // 
            // toolTipConfiguration
            // 
            this.toolTipConfiguration.AutomaticDelay = 100;
            this.toolTipConfiguration.AutoPopDelay = 1000;
            this.toolTipConfiguration.InitialDelay = 100;
            this.toolTipConfiguration.ReshowDelay = 20;
            // 
            // toolTipSeat
            // 
            this.toolTipSeat.AutomaticDelay = 100;
            this.toolTipSeat.AutoPopDelay = 1000;
            this.toolTipSeat.InitialDelay = 100;
            this.toolTipSeat.ReshowDelay = 20;
            // 
            // toolTipAdmin
            // 
            this.toolTipAdmin.AutomaticDelay = 100;
            this.toolTipAdmin.AutoPopDelay = 1000;
            this.toolTipAdmin.InitialDelay = 100;
            this.toolTipAdmin.ReshowDelay = 20;
            // 
            // toolTipEntry
            // 
            this.toolTipEntry.AutomaticDelay = 100;
            this.toolTipEntry.AutoPopDelay = 1000;
            this.toolTipEntry.InitialDelay = 100;
            this.toolTipEntry.ReshowDelay = 20;
            // 
            // toolTipLogout
            // 
            this.toolTipLogout.AutomaticDelay = 100;
            this.toolTipLogout.AutoPopDelay = 1000;
            this.toolTipLogout.InitialDelay = 100;
            this.toolTipLogout.ReshowDelay = 20;
            // 
            // toolTipMenu
            // 
            this.toolTipMenu.AutomaticDelay = 100;
            this.toolTipMenu.AutoPopDelay = 1000;
            this.toolTipMenu.InitialDelay = 100;
            this.toolTipMenu.ReshowDelay = 20;
            // 
            // toolTipMovie
            // 
            this.toolTipMovie.AutomaticDelay = 100;
            this.toolTipMovie.AutoPopDelay = 1000;
            this.toolTipMovie.InitialDelay = 100;
            this.toolTipMovie.ReshowDelay = 20;
            // 
            // toolTipReport
            // 
            this.toolTipReport.AutomaticDelay = 100;
            this.toolTipReport.AutoPopDelay = 1000;
            this.toolTipReport.InitialDelay = 100;
            this.toolTipReport.ReshowDelay = 20;
            // 
            // toolTipStaffs
            // 
            this.toolTipStaffs.AutomaticDelay = 100;
            this.toolTipStaffs.AutoPopDelay = 1000;
            this.toolTipStaffs.InitialDelay = 100;
            this.toolTipStaffs.ReshowDelay = 20;
            // 
            // toolTipTicket
            // 
            this.toolTipTicket.AutomaticDelay = 100;
            this.toolTipTicket.AutoPopDelay = 1000;
            this.toolTipTicket.InitialDelay = 100;
            this.toolTipTicket.ReshowDelay = 20;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelleft);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panelleft.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelEntry.ResumeLayout(false);
            this.panelConfiguration.ResumeLayout(false);
            this.panelMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelAccountShow.ResumeLayout(false);
            this.panelAccountShow.PerformLayout();
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelConfiguration;
        private FontAwesome.Sharp.IconButton btnConfiguration;
        private FontAwesome.Sharp.IconButton btnEntry;
        private FontAwesome.Sharp.IconButton btnlogout;
        private System.Windows.Forms.ToolTip toolTipHome;
        private System.Windows.Forms.ToolTip toolTipConfiguration;
        private System.Windows.Forms.ToolTip toolTipSeat;
        private System.Windows.Forms.ToolTip toolTipAdmin;
        private System.Windows.Forms.ToolTip toolTipEntry;
        private System.Windows.Forms.ToolTip toolTipLogout;
        private System.Windows.Forms.ToolTip toolTipMenu;
        private System.Windows.Forms.ToolTip toolTipMovie;
        private System.Windows.Forms.ToolTip toolTipReport;
        private System.Windows.Forms.ToolTip toolTipStaffs;
        private System.Windows.Forms.ToolTip toolTipTicket;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Label txtLoginNameForMain;
        private System.Windows.Forms.Label lblTitleChildForm;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        public System.Windows.Forms.Panel panelleft;
        public System.Windows.Forms.Panel panelMenuBar;
        public Guna.UI2.WinForms.Guna2Panel paneltitlebar;
        public FontAwesome.Sharp.IconButton btnAccount;
        public Guna.UI2.WinForms.Guna2Panel panelAccountShow;
        public FontAwesome.Sharp.IconButton accountimage;
        public System.Windows.Forms.Panel panelEntry;
        public FontAwesome.Sharp.IconButton btnAdmin;
        public FontAwesome.Sharp.IconButton btnStaff;
        public FontAwesome.Sharp.IconButton btnHome;
        public FontAwesome.Sharp.IconButton btnMovie;
        public FontAwesome.Sharp.IconButton btnSeat;
        public FontAwesome.Sharp.IconButton btnTicket;
        public FontAwesome.Sharp.IconButton btnReport;
    }
}