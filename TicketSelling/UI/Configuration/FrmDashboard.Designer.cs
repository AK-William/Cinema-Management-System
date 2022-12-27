namespace TicketSelling.UI.Configuration
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvMovieDB = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colimg1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colimg2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colimg3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colimg4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MovieCover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDB)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.guna2Panel2);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 718);
            this.panel1.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.ImageRotate = 0F;
            this.pb.Location = new System.Drawing.Point(378, 399);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(247, 276);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvMovieDB);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 62);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1137, 280);
            this.guna2Panel2.TabIndex = 1;
            // 
            // dgvMovieDB
            // 
            this.dgvMovieDB.AllowUserToAddRows = false;
            this.dgvMovieDB.AllowUserToDeleteRows = false;
            this.dgvMovieDB.AllowUserToResizeColumns = false;
            this.dgvMovieDB.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMovieDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovieDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovieDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovieDB.ColumnHeadersHeight = 35;
            this.dgvMovieDB.ColumnHeadersVisible = false;
            this.dgvMovieDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colimg1,
            this.colimg2,
            this.colimg3,
            this.colimg4,
            this.MovieCover});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovieDB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovieDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovieDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMovieDB.Location = new System.Drawing.Point(0, 0);
            this.dgvMovieDB.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMovieDB.Name = "dgvMovieDB";
            this.dgvMovieDB.ReadOnly = true;
            this.dgvMovieDB.RowHeadersVisible = false;
            this.dgvMovieDB.RowTemplate.Height = 30;
            this.dgvMovieDB.Size = new System.Drawing.Size(1137, 280);
            this.dgvMovieDB.TabIndex = 2;
            this.dgvMovieDB.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovieDB.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMovieDB.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMovieDB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMovieDB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMovieDB.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovieDB.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMovieDB.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvMovieDB.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMovieDB.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovieDB.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMovieDB.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMovieDB.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMovieDB.ThemeStyle.ReadOnly = true;
            this.dgvMovieDB.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovieDB.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovieDB.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovieDB.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMovieDB.ThemeStyle.RowsStyle.Height = 30;
            this.dgvMovieDB.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMovieDB.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colimg1
            // 
            this.colimg1.DataPropertyName = "MovieCoverByte";
            this.colimg1.HeaderText = "";
            this.colimg1.Name = "colimg1";
            this.colimg1.ReadOnly = true;
            // 
            // colimg2
            // 
            this.colimg2.HeaderText = "";
            this.colimg2.Name = "colimg2";
            this.colimg2.ReadOnly = true;
            // 
            // colimg3
            // 
            this.colimg3.HeaderText = "";
            this.colimg3.Name = "colimg3";
            this.colimg3.ReadOnly = true;
            // 
            // colimg4
            // 
            this.colimg4.HeaderText = "";
            this.colimg4.Name = "colimg4";
            this.colimg4.ReadOnly = true;
            // 
            // MovieCover
            // 
            this.MovieCover.DataPropertyName = "MovieCover";
            this.MovieCover.HeaderText = "MovieCover";
            this.MovieCover.Name = "MovieCover";
            this.MovieCover.ReadOnly = true;
            this.MovieCover.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1137, 62);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(405, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(313, 47);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "NOW SHOWING";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDashboard";
            this.Size = new System.Drawing.Size(1137, 718);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDB)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2DataGridView dgvMovieDB;
        private System.Windows.Forms.DataGridViewImageColumn colimg1;
        private System.Windows.Forms.DataGridViewImageColumn colimg2;
        private System.Windows.Forms.DataGridViewImageColumn colimg3;
        private System.Windows.Forms.DataGridViewImageColumn colimg4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCover;
        private Guna.UI2.WinForms.Guna2PictureBox pb;
    }
}