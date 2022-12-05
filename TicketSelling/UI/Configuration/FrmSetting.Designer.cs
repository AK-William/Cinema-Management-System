namespace TicketSelling.UI.Configuration
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbChangeLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbChangeColor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // guna2Panel3
            // 
            resources.ApplyResources(this.guna2Panel3, "guna2Panel3");
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel3.Controls.Add(this.cbChangeLanguage);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            // 
            // guna2HtmlLabel2
            // 
            resources.ApplyResources(this.guna2HtmlLabel2, "guna2HtmlLabel2");
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            // 
            // cbChangeLanguage
            // 
            resources.ApplyResources(this.cbChangeLanguage, "cbChangeLanguage");
            this.cbChangeLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cbChangeLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChangeLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChangeLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChangeLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChangeLanguage.Items.AddRange(new object[] {
            resources.GetString("cbChangeLanguage.Items"),
            resources.GetString("cbChangeLanguage.Items1")});
            this.cbChangeLanguage.Name = "cbChangeLanguage";
            this.cbChangeLanguage.SelectedIndexChanged += new System.EventHandler(this.CbChangeLanguage_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.cbChangeColor);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            // 
            // guna2HtmlLabel1
            // 
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // cbChangeColor
            // 
            resources.ApplyResources(this.cbChangeColor, "cbChangeColor");
            this.cbChangeColor.BackColor = System.Drawing.Color.Transparent;
            this.cbChangeColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChangeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeColor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChangeColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChangeColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChangeColor.Items.AddRange(new object[] {
            resources.GetString("cbChangeColor.Items"),
            resources.GetString("cbChangeColor.Items1"),
            resources.GetString("cbChangeColor.Items2"),
            resources.GetString("cbChangeColor.Items3"),
            resources.GetString("cbChangeColor.Items4"),
            resources.GetString("cbChangeColor.Items5")});
            this.cbChangeColor.Name = "cbChangeColor";
            this.cbChangeColor.SelectedIndexChanged += new System.EventHandler(this.CbChangeColor_SelectedIndexChanged);
            // 
            // FrmSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmSetting";
            this.Tag = "Setting";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbChangeColor;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbChangeLanguage;
    }
}