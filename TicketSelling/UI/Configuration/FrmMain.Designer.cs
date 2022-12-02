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
            this.txtLoginNameForMain = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
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
            this.paneltitlebar = new Guna.UI2.WinForms.Guna2Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.panelleft.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelEntry.SuspendLayout();
            this.panelConfiguration.SuspendLayout();
            this.panelMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelAccountShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.paneltitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelleft.Controls.Add(this.panelMenu);
            this.panelleft.Controls.Add(this.panelMenuBar);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(266, 681);
            this.panelleft.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnlogout);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnTicket);
            this.panelMenu.Controls.Add(this.panelEntry);
            this.panelMenu.Controls.Add(this.panelConfiguration);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 154);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(266, 527);
            this.panelMenu.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnlogout.IconColor = System.Drawing.Color.White;
            this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 457);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(266, 70);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Tag = "Logout";
            this.btnlogout.Text = "    Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            this.btnlogout.MouseHover += new System.EventHandler(this.Btnlogout_MouseHover);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReport.IconColor = System.Drawing.Color.White;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 277);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(266, 70);
            this.btnReport.TabIndex = 3;
            this.btnReport.Tag = "Report";
            this.btnReport.Text = "    Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            this.btnReport.MouseHover += new System.EventHandler(this.BtnReport_MouseHover);
            // 
            // btnTicket
            // 
            this.btnTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btnTicket.IconColor = System.Drawing.Color.White;
            this.btnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(0, 207);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTicket.Size = new System.Drawing.Size(266, 70);
            this.btnTicket.TabIndex = 2;
            this.btnTicket.Tag = "Ticket";
            this.btnTicket.Text = "    Ticket";
            this.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.BtnTicket_Click);
            this.btnTicket.MouseHover += new System.EventHandler(this.BtnTicket_MouseHover);
            // 
            // panelEntry
            // 
            this.panelEntry.Controls.Add(this.btnStaff);
            this.panelEntry.Controls.Add(this.btnAdmin);
            this.panelEntry.Controls.Add(this.btnEntry);
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntry.Location = new System.Drawing.Point(0, 137);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(266, 70);
            this.panelEntry.TabIndex = 0;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnStaff.IconColor = System.Drawing.Color.White;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 130);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(266, 60);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.TabStop = false;
            this.btnStaff.Tag = "Staff";
            this.btnStaff.Text = "    Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 70);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(266, 60);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.TabStop = false;
            this.btnAdmin.Tag = "Admin";
            this.btnAdmin.Text = "    Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            this.btnEntry.IconColor = System.Drawing.Color.White;
            this.btnEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.Location = new System.Drawing.Point(0, 0);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEntry.Size = new System.Drawing.Size(266, 70);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.TabStop = false;
            this.btnEntry.Tag = "Entry";
            this.btnEntry.Text = "    Entry Form";
            this.btnEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            this.btnEntry.MouseHover += new System.EventHandler(this.BtnEntry_MouseHover);
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Controls.Add(this.btnMovie);
            this.panelConfiguration.Controls.Add(this.btnSeat);
            this.panelConfiguration.Controls.Add(this.btnConfiguration);
            this.panelConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfiguration.Location = new System.Drawing.Point(0, 70);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(266, 67);
            this.panelConfiguration.TabIndex = 0;
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnMovie.IconColor = System.Drawing.Color.White;
            this.btnMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.Location = new System.Drawing.Point(0, 130);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMovie.Size = new System.Drawing.Size(266, 60);
            this.btnMovie.TabIndex = 4;
            this.btnMovie.Tag = "Movie";
            this.btnMovie.Text = "    Movie";
            this.btnMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovie.UseVisualStyleBackColor = false;
            this.btnMovie.Click += new System.EventHandler(this.BtnMovie_Click);
            this.btnMovie.MouseHover += new System.EventHandler(this.BtnMovie_MouseHover);
            // 
            // btnSeat
            // 
            this.btnSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeat.FlatAppearance.BorderSize = 0;
            this.btnSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeat.ForeColor = System.Drawing.Color.White;
            this.btnSeat.IconChar = FontAwesome.Sharp.IconChar.Couch;
            this.btnSeat.IconColor = System.Drawing.Color.White;
            this.btnSeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeat.Location = new System.Drawing.Point(0, 70);
            this.btnSeat.Name = "btnSeat";
            this.btnSeat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSeat.Size = new System.Drawing.Size(266, 60);
            this.btnSeat.TabIndex = 3;
            this.btnSeat.Tag = "Seat";
            this.btnSeat.Text = "    Seat";
            this.btnSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeat.UseVisualStyleBackColor = false;
            this.btnSeat.Click += new System.EventHandler(this.BtnSeat_Click);
            this.btnSeat.MouseHover += new System.EventHandler(this.BtnSeat_MouseHover);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguration.FlatAppearance.BorderSize = 0;
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.ForeColor = System.Drawing.Color.White;
            this.btnConfiguration.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btnConfiguration.IconColor = System.Drawing.Color.White;
            this.btnConfiguration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguration.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfiguration.Size = new System.Drawing.Size(266, 70);
            this.btnConfiguration.TabIndex = 2;
            this.btnConfiguration.Tag = "Configuration";
            this.btnConfiguration.Text = "    Configuration";
            this.btnConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.BtnConfiguration_Click);
            this.btnConfiguration.MouseHover += new System.EventHandler(this.BtnConfiguration_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(266, 70);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.btnHome.MouseHover += new System.EventHandler(this.BtnHome_MouseHover);
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.Controls.Add(this.btnMenu);
            this.panelMenuBar.Controls.Add(this.pictureBox1);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(266, 154);
            this.panelMenuBar.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::TicketSelling.Properties.Resources.Menu_512px;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Location = new System.Drawing.Point(179, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            this.btnMenu.MouseHover += new System.EventHandler(this.BtnMenu_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketSelling.Properties.Resources.welcome_cinema_neon_sign_popcorn_260nw_1178142151;
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
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
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(266, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(889, 101);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // panelAccountShow
            // 
            this.panelAccountShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAccountShow.BackColor = System.Drawing.Color.Transparent;
            this.panelAccountShow.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelAccountShow.BorderThickness = 2;
            this.panelAccountShow.Controls.Add(this.txtLoginNameForMain);
            this.panelAccountShow.Controls.Add(this.guna2CirclePictureBox1);
            this.panelAccountShow.Location = new System.Drawing.Point(571, 5);
            this.panelAccountShow.Name = "panelAccountShow";
            this.panelAccountShow.Size = new System.Drawing.Size(170, 93);
            this.panelAccountShow.TabIndex = 2;
            this.panelAccountShow.Tag = "AS";
            this.panelAccountShow.UseTransparentBackground = true;
            this.panelAccountShow.Visible = false;
            // 
            // txtLoginNameForMain
            // 
            this.txtLoginNameForMain.AllowDrop = true;
            this.txtLoginNameForMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginNameForMain.AutoEllipsis = true;
            this.txtLoginNameForMain.AutoSize = true;
            this.txtLoginNameForMain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginNameForMain.ForeColor = System.Drawing.Color.Black;
            this.txtLoginNameForMain.Location = new System.Drawing.Point(54, 68);
            this.txtLoginNameForMain.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtLoginNameForMain.Name = "txtLoginNameForMain";
            this.txtLoginNameForMain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtLoginNameForMain.Size = new System.Drawing.Size(65, 21);
            this.txtLoginNameForMain.TabIndex = 9;
            this.txtLoginNameForMain.Text = "User";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::TicketSelling.Properties.Resources.test_account_480px;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(56, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(58, 51);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccount.AutoEllipsis = true;
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnAccount.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.Location = new System.Drawing.Point(744, 31);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(68, 61);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.AutoEllipsis = true;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.Gray;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.Location = new System.Drawing.Point(818, 31);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(68, 61);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hi There!";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(182)))), ((int)(((byte)(211)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(754, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(799, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(842, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // toolTipHome
            // 
            this.toolTipHome.AutomaticDelay = 100;
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
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.paneltitlebar.Controls.Add(this.iconCurrentChildForm);
            this.paneltitlebar.Controls.Add(this.lblTitleChildForm);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(266, 101);
            this.paneltitlebar.Margin = new System.Windows.Forms.Padding(2);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(889, 53);
            this.paneltitlebar.TabIndex = 2;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.Enabled = false;
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(50, 53);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(59, 13);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(61, 23);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(266, 154);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(889, 527);
            this.panelBody.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 681);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelleft);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMenuBar;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelConfiguration;
        private FontAwesome.Sharp.IconButton btnMovie;
        private FontAwesome.Sharp.IconButton btnSeat;
        private FontAwesome.Sharp.IconButton btnConfiguration;
        private System.Windows.Forms.Panel panelEntry;
        private FontAwesome.Sharp.IconButton btnEntry;
        private FontAwesome.Sharp.IconButton btnTicket;
        private FontAwesome.Sharp.IconButton btnlogout;
        private FontAwesome.Sharp.IconButton btnReport;
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
        private FontAwesome.Sharp.IconButton btnAccount;
        private Guna.UI2.WinForms.Guna2Panel panelAccountShow;
        private System.Windows.Forms.Label txtLoginNameForMain;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnStaff;
        private Guna.UI2.WinForms.Guna2Panel paneltitlebar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
    }
}