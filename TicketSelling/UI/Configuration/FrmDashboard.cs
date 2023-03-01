using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;
using TicketSelling.UI.FrmMessageBox;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmDashboard : UserControl
    {
        public List<Movie> lstMovie = new List<Movie>();
        int X = 30, Y = 23;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            GetAllMovie();

            if (lstMovie != null)
            {
                CreateMovie();
            }

            GetAllMovieSummary();
        }

        public void GetAllMovie()
        {
            try
            {
                lstMovie = null;
                ResMovie res = new DashboardDao().GetAllMovie();
                if (res.LstMovie.Count > 0)
                {
                    lstMovie = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                FrmError frm = new FrmError();
                frm.lblError.Text = ex.Message;
                frm.ShowDialog();
            }
        }

        public void GetAllMovieSummary()
        {
            try
            {
                dgvSummary.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieSummary();
                if (res.lstMovieSummary.Count > 0)
                {
                    dgvSummary.DataSource = res.lstMovieSummary;
                }
            }
            catch (Exception ex)
            {
                FrmError frm = new FrmError();
                frm.lblError.Text = ex.Message;
                frm.ShowDialog();
            }
        }

        public void CreateMovie()
        {
            try
            {
                pnlAllMovie.Controls.Clear();
                for (int i = 0; i < lstMovie.Count; i++)
                {
                    var item = lstMovie[i];
                    Guna2Panel pnlMovie = new Guna2Panel();
                    Guna2Panel pnlMovieCover = new Guna2Panel();
                    Guna2Panel pnlMovieName = new Guna2Panel();
                    Label lblMovie = new Label();
                    PictureBox PictureBox = new PictureBox();

                    // lblMovie
                    lblMovie.Dock = System.Windows.Forms.DockStyle.Fill;
                    lblMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblMovie.Location = new System.Drawing.Point(0, 0);
                    lblMovie.Name = "lblMovie";
                    lblMovie.Size = new System.Drawing.Size(257, 60);
                    lblMovie.TabIndex = 0;
                    lblMovie.Text = item.Name;
                    lblMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    pnlMovieName.Controls.Add(lblMovie);
                    pnlMovieName.Dock = System.Windows.Forms.DockStyle.Fill;
                    pnlMovieName.Location = new System.Drawing.Point(0, 233);
                    pnlMovieName.Name = "pnlMovieName";
                    pnlMovieName.Size = new System.Drawing.Size(257, 60);
                    pnlMovieName.TabIndex = 1;

                    //PictureBox
                    PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
                    PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    PictureBox.Location = new System.Drawing.Point(0, 0);
                    PictureBox.Name = "PictureBox";
                    PictureBox.Size = new System.Drawing.Size(257, 233);
                    PictureBox.TabIndex = 0;
                    PictureBox.TabStop = false;
                    PictureBox.Image = Image.FromStream(new MemoryStream(item.MovieCoverByte));

                    // pnlMovieCover
                    pnlMovieCover.BackColor = System.Drawing.Color.Transparent;
                    pnlMovieCover.Controls.Add(PictureBox);
                    pnlMovieCover.Dock = System.Windows.Forms.DockStyle.Top;
                    pnlMovieCover.Location = new System.Drawing.Point(0, 0);
                    pnlMovieCover.Name = "pnlMovieCover";
                    pnlMovieCover.Size = new System.Drawing.Size(257, 233);
                    pnlMovieCover.TabIndex = 0;

                    pnlMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
                    pnlMovie.Controls.Add(pnlMovieName);
                    pnlMovie.Controls.Add(pnlMovieCover);
                    pnlMovie.Location = new System.Drawing.Point(X, Y);
                    pnlMovie.Name = "pnlMovie";
                    pnlMovie.ShadowDecoration.Color = System.Drawing.Color.Aqua;
                    pnlMovie.ShadowDecoration.Enabled = true;
                    pnlMovie.Size = new System.Drawing.Size(257, 293);
                    pnlMovie.TabIndex = 0;

                    pnlAllMovie.Controls.Add(pnlMovie);

                    X += pnlMovie.Width + 45;

                    //if (((i + 1) % 5) == 0)
                    //{
                    //    X = 7;
                    //    Y += pnlMovie.Height + 20;
                    //}
                }
            }
            catch (Exception ex)
            {
                FrmError frm = new FrmError();
                frm.lblError.Text = ex.Message;
                frm.ShowDialog();
            }
        }

    }
}
