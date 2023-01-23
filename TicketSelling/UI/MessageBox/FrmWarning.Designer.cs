namespace TicketSelling.UI.FrmMessageBox
{
    partial class FrmWarning
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
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnWarningExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnWarningOk = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWarningExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 2;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(400, 250);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.guna2Panel4.Controls.Add(this.btnWarningExit);
            this.guna2Panel4.Controls.Add(this.pictureBox1);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(400, 131);
            this.guna2Panel4.TabIndex = 9;
            // 
            // btnWarningExit
            // 
            this.btnWarningExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWarningExit.BackColor = System.Drawing.Color.Transparent;
            this.btnWarningExit.Image = global::TicketSelling.Properties.Resources.Close_480px;
            this.btnWarningExit.ImageRotate = 0F;
            this.btnWarningExit.Location = new System.Drawing.Point(358, 12);
            this.btnWarningExit.Name = "btnWarningExit";
            this.btnWarningExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnWarningExit.Size = new System.Drawing.Size(30, 30);
            this.btnWarningExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnWarningExit.TabIndex = 6;
            this.btnWarningExit.TabStop = false;
            this.btnWarningExit.UseTransparentBackground = true;
            this.btnWarningExit.Click += new System.EventHandler(this.BtnWarningExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::TicketSelling.Properties.Resources.error_480px;
            this.pictureBox1.Location = new System.Drawing.Point(154, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.lblWarning);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 131);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(400, 64);
            this.guna2Panel3.TabIndex = 8;
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarning.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(0, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(400, 64);
            this.lblWarning.TabIndex = 7;
            this.lblWarning.Text = "TEXT";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.btnWarningOk);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 195);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(400, 55);
            this.guna2Panel2.TabIndex = 7;
            // 
            // btnWarningOk
            // 
            this.btnWarningOk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWarningOk.Animated = true;
            this.btnWarningOk.BackColor = System.Drawing.Color.Silver;
            this.btnWarningOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWarningOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWarningOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWarningOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWarningOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.btnWarningOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarningOk.ForeColor = System.Drawing.Color.Black;
            this.btnWarningOk.Location = new System.Drawing.Point(120, 6);
            this.btnWarningOk.Name = "btnWarningOk";
            this.btnWarningOk.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWarningOk.ShadowDecoration.Depth = 10;
            this.btnWarningOk.ShadowDecoration.Enabled = true;
            this.btnWarningOk.Size = new System.Drawing.Size(152, 40);
            this.btnWarningOk.TabIndex = 4;
            this.btnWarningOk.Text = "OK";
            this.btnWarningOk.Click += new System.EventHandler(this.BtnWarningOk_Click_1);
            // 
            // FrmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWarning";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnWarningExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnWarningOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        public System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnWarningExit;
    }
}