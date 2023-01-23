namespace TicketSelling.UI.Report
{
    partial class FrmTicketSellReportByDate
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
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMovie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rbByCustom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbByMonth = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbByWeek = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbByDay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTop.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderThickness = 3;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTop.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 63);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(13, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 33);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Check Report By Date";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 63);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 437);
            this.guna2Panel2.TabIndex = 3;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.lblDate);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.cbMovie);
            this.guna2Panel3.Controls.Add(this.btnView);
            this.guna2Panel3.Controls.Add(this.lblToDate);
            this.guna2Panel3.Controls.Add(this.lblFromDate);
            this.guna2Panel3.Controls.Add(this.dpToDate);
            this.guna2Panel3.Controls.Add(this.dpFromDate);
            this.guna2Panel3.Controls.Add(this.rbByCustom);
            this.guna2Panel3.Controls.Add(this.rbByMonth);
            this.guna2Panel3.Controls.Add(this.rbByWeek);
            this.guna2Panel3.Controls.Add(this.rbByDay);
            this.guna2Panel3.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.guna2Panel3.Location = new System.Drawing.Point(35, 33);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.DeepSkyBlue;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.Size = new System.Drawing.Size(731, 365);
            this.guna2Panel3.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(41, 165);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            this.lblDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Movie";
            // 
            // cbMovie
            // 
            this.cbMovie.BackColor = System.Drawing.Color.Transparent;
            this.cbMovie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMovie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovie.ForeColor = System.Drawing.Color.Black;
            this.cbMovie.ItemHeight = 35;
            this.cbMovie.Location = new System.Drawing.Point(173, 24);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(271, 41);
            this.cbMovie.TabIndex = 10;
            // 
            // btnView
            // 
            this.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(309, 284);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(111, 53);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "VIEW";
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.Black;
            this.lblToDate.Location = new System.Drawing.Point(398, 165);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(62, 19);
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "To Date";
            this.lblToDate.Visible = false;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.Black;
            this.lblFromDate.Location = new System.Drawing.Point(41, 165);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(82, 19);
            this.lblFromDate.TabIndex = 6;
            this.lblFromDate.Text = "From Date";
            this.lblFromDate.Visible = false;
            // 
            // dpToDate
            // 
            this.dpToDate.Checked = true;
            this.dpToDate.CustomFormat = "dd-MM-yyyy";
            this.dpToDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dpToDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpToDate.ForeColor = System.Drawing.Color.Black;
            this.dpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpToDate.Location = new System.Drawing.Point(402, 206);
            this.dpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpToDate.Name = "dpToDate";
            this.dpToDate.Size = new System.Drawing.Size(272, 49);
            this.dpToDate.TabIndex = 5;
            this.dpToDate.Value = new System.DateTime(2023, 1, 22, 10, 50, 11, 763);
            this.dpToDate.Visible = false;
            // 
            // dpFromDate
            // 
            this.dpFromDate.Checked = true;
            this.dpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dpFromDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dpFromDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFromDate.ForeColor = System.Drawing.Color.Black;
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.Location = new System.Drawing.Point(45, 206);
            this.dpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(272, 49);
            this.dpFromDate.TabIndex = 4;
            this.dpFromDate.Value = new System.DateTime(2023, 1, 22, 11, 11, 37, 99);
            // 
            // rbByCustom
            // 
            this.rbByCustom.AutoSize = true;
            this.rbByCustom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByCustom.CheckedState.BorderThickness = 0;
            this.rbByCustom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByCustom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbByCustom.CheckedState.InnerOffset = -4;
            this.rbByCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbByCustom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByCustom.ForeColor = System.Drawing.Color.Black;
            this.rbByCustom.Location = new System.Drawing.Point(573, 97);
            this.rbByCustom.Name = "rbByCustom";
            this.rbByCustom.Size = new System.Drawing.Size(105, 23);
            this.rbByCustom.TabIndex = 3;
            this.rbByCustom.Text = "By Custom";
            this.rbByCustom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbByCustom.UncheckedState.BorderThickness = 2;
            this.rbByCustom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbByCustom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbByCustom.CheckedChanged += new System.EventHandler(this.RbByCustom_CheckedChanged);
            // 
            // rbByMonth
            // 
            this.rbByMonth.AutoSize = true;
            this.rbByMonth.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByMonth.CheckedState.BorderThickness = 0;
            this.rbByMonth.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByMonth.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbByMonth.CheckedState.InnerOffset = -4;
            this.rbByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbByMonth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByMonth.ForeColor = System.Drawing.Color.Black;
            this.rbByMonth.Location = new System.Drawing.Point(402, 97);
            this.rbByMonth.Name = "rbByMonth";
            this.rbByMonth.Size = new System.Drawing.Size(97, 23);
            this.rbByMonth.TabIndex = 2;
            this.rbByMonth.Text = "By Month";
            this.rbByMonth.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbByMonth.UncheckedState.BorderThickness = 2;
            this.rbByMonth.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbByMonth.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbByMonth.CheckedChanged += new System.EventHandler(this.RbByMonth_CheckedChanged);
            // 
            // rbByWeek
            // 
            this.rbByWeek.AutoSize = true;
            this.rbByWeek.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByWeek.CheckedState.BorderThickness = 0;
            this.rbByWeek.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByWeek.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbByWeek.CheckedState.InnerOffset = -4;
            this.rbByWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbByWeek.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByWeek.ForeColor = System.Drawing.Color.Black;
            this.rbByWeek.Location = new System.Drawing.Point(216, 97);
            this.rbByWeek.Name = "rbByWeek";
            this.rbByWeek.Size = new System.Drawing.Size(91, 23);
            this.rbByWeek.TabIndex = 1;
            this.rbByWeek.Text = "By Week";
            this.rbByWeek.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbByWeek.UncheckedState.BorderThickness = 2;
            this.rbByWeek.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbByWeek.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbByWeek.CheckedChanged += new System.EventHandler(this.RbByWeek_CheckedChanged);
            // 
            // rbByDay
            // 
            this.rbByDay.AutoSize = true;
            this.rbByDay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByDay.CheckedState.BorderThickness = 0;
            this.rbByDay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbByDay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbByDay.CheckedState.InnerOffset = -4;
            this.rbByDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbByDay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbByDay.ForeColor = System.Drawing.Color.Black;
            this.rbByDay.Location = new System.Drawing.Point(45, 97);
            this.rbByDay.Name = "rbByDay";
            this.rbByDay.Size = new System.Drawing.Size(79, 23);
            this.rbByDay.TabIndex = 0;
            this.rbByDay.Text = "By Day";
            this.rbByDay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbByDay.UncheckedState.BorderThickness = 2;
            this.rbByDay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbByDay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbByDay.CheckedChanged += new System.EventHandler(this.RbByDay_CheckedChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.panelTop);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 500);
            this.guna2Panel1.TabIndex = 4;
            // 
            // FrmTicketSellReportByDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmTicketSellReportByDate";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.FrmTicketSellReportByDate_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2RadioButton rbByCustom;
        private Guna.UI2.WinForms.Guna2RadioButton rbByMonth;
        private Guna.UI2.WinForms.Guna2RadioButton rbByWeek;
        private Guna.UI2.WinForms.Guna2RadioButton rbByDay;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpFromDate;
        private Guna.UI2.WinForms.Guna2Button btnView;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbMovie;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}