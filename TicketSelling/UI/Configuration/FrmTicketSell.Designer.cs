namespace TicketSelling.UI.Configuration
{
    partial class FrmTicketSell
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMid = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBot = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.dpMovieDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMovieName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panelMid);
            this.guna2Panel1.Controls.Add(this.panelBot);
            this.guna2Panel1.Controls.Add(this.panelTop);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1390, 816);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panelMid
            // 
            this.panelMid.AutoScroll = true;
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 90);
            this.panelMid.Name = "panelMid";
            this.panelMid.ShadowDecoration.Depth = 5;
            this.panelMid.Size = new System.Drawing.Size(1390, 656);
            this.panelMid.TabIndex = 2;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.btnCheck);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 746);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1390, 70);
            this.panelBot.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnCheck.IconColor = System.Drawing.Color.White;
            this.btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheck.IconSize = 30;
            this.btnCheck.Location = new System.Drawing.Point(1258, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(129, 59);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // panelTop
            // 
            this.panelTop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelTop.Controls.Add(this.dpMovieDate);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.cboTime);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.cboMovieName);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panelTop.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1390, 90);
            this.panelTop.TabIndex = 0;
            // 
            // dpMovieDate
            // 
            this.dpMovieDate.Checked = true;
            this.dpMovieDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dpMovieDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpMovieDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpMovieDate.Location = new System.Drawing.Point(574, 21);
            this.dpMovieDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpMovieDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpMovieDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpMovieDate.Name = "dpMovieDate";
            this.dpMovieDate.Size = new System.Drawing.Size(335, 46);
            this.dpMovieDate.TabIndex = 5;
            this.dpMovieDate.Value = new System.DateTime(2023, 1, 17, 15, 8, 44, 179);
            this.dpMovieDate.ValueChanged += new System.EventHandler(this.CboDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // cboTime
            // 
            this.cboTime.BackColor = System.Drawing.Color.Transparent;
            this.cboTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTime.ItemHeight = 40;
            this.cboTime.Location = new System.Drawing.Point(1038, 21);
            this.cboTime.Margin = new System.Windows.Forms.Padding(4);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(286, 46);
            this.cboTime.TabIndex = 3;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.CboTime_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(971, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // cboMovieName
            // 
            this.cboMovieName.BackColor = System.Drawing.Color.Transparent;
            this.cboMovieName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovieName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMovieName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMovieName.ItemHeight = 40;
            this.cboMovieName.Location = new System.Drawing.Point(99, 21);
            this.cboMovieName.Margin = new System.Windows.Forms.Padding(4);
            this.cboMovieName.Name = "cboMovieName";
            this.cboMovieName.Size = new System.Drawing.Size(345, 46);
            this.cboMovieName.TabIndex = 1;
            this.cboMovieName.SelectedIndexChanged += new System.EventHandler(this.CboMovieName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie";
            // 
            // FrmTicketSell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTicketSell";
            this.Size = new System.Drawing.Size(1390, 816);
            this.Load += new System.EventHandler(this.FrmTicketSell_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2ComboBox cboMovieName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpMovieDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cboTime;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelBot;
        private FontAwesome.Sharp.IconButton btnCheck;
        private Guna.UI2.WinForms.Guna2Panel panelMid;
    }
}