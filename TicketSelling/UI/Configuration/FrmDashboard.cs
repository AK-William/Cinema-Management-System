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
            //colorchangeseat();
            //colordaynight();
        }

        //#region theme color change

        //FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        //public void colorchangeseat()
        //{
        //    if (frmmain.panelleft.BackColor == Color.FromArgb(253, 73, 131))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
        //    }
        //    else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 120, 215))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
        //    }
        //    else if (frmmain.panelleft.BackColor == Color.FromArgb(27, 182, 211))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
        //    }
        //    else if (frmmain.panelleft.BackColor == Color.FromArgb(123, 31, 162))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
        //    }
        //    else if (frmmain.panelleft.BackColor == Color.FromArgb(84, 110, 122))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
        //    }
        //    else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 200, 83))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
        //    }
        //    else if (frmmain.panelleft.BackColor == Color.FromArgb(217, 115, 65))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 115, 65);
        //    }
        //    else if (frmmain.panelleft.BackColor == Color.FromArgb(196, 30, 58))
        //    {
        //        dgvSummary.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
        //    }
        //}

        //public void colordaynight()
        //{
        //    if (frmmain.panelTitle.BackColor == Color.FromArgb(41, 47, 57))
        //    {
        //        guna2Panel1.BackColor = Color.FromArgb(43, 55, 61);
        //        //lblseattypename.ForeColor = Color.White;
        //        //lblseattypenote.ForeColor = Color.White;
        //        //txtSeatTypeName.FillColor = Color.FromArgb(45, 57, 68);
        //        //txtSeatTypeName.ForeColor = Color.White;
        //        //txtSeatTypeNote.FillColor = Color.FromArgb(45, 57, 68);
        //        //txtSeatTypeNote.ForeColor = Color.White;
        //        //dgvSeatType.BackgroundColor = Color.FromArgb(68, 87, 96);
        //        //dgvSeatType.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
        //        //dgvSeatType.DefaultCellStyle.ForeColor = Color.White;
        //        //dgvSeatType.GridColor = Color.FromArgb(41, 47, 57);
        //        //dgvSeatType.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
        //        //dgvSeatType.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
        //        //dgvSeatType.DefaultCellStyle.SelectionForeColor = Color.White;

        //        //tabSeat.BackColor = Color.FromArgb(43, 55, 61);
        //        //lblSeatname.ForeColor = Color.White;
        //        //lblnote.ForeColor = Color.White;
        //        //lblnumberofseats.ForeColor = Color.White;
        //        //lblprice.ForeColor = Color.White;
        //        //cbSeatType.FillColor = Color.FromArgb(45, 57, 68);
        //        //txtSeatNote.FillColor = Color.FromArgb(45, 57, 68);
        //        //txtNumberOfSeats.FillColor = Color.FromArgb(45, 57, 68);
        //        //txtSeatPrice.FillColor = Color.FromArgb(45, 57, 68);
        //        //cbSeatType.ForeColor = Color.White;
        //        //txtSeatNote.ForeColor = Color.White;
        //        //txtNumberOfSeats.ForeColor = Color.White;
        //        //txtSeatPrice.ForeColor = Color.White;
        //        //dgvSeat.BackgroundColor = Color.FromArgb(68, 87, 96);
        //        //dgvSeat.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
        //        //dgvSeat.DefaultCellStyle.ForeColor = Color.White;
        //        //dgvSeat.GridColor = Color.FromArgb(41, 47, 57);
        //        //dgvSeat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
        //        //dgvSeat.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
        //        //dgvSeat.DefaultCellStyle.SelectionForeColor = Color.White;
        //    }
        //    else
        //    {
        //        guna2Panel1.BackColor = Color.White;
        //        //lblseattypename.ForeColor = Color.Black;
        //        //lblseattypenote.ForeColor = Color.Black;
        //    }
        //}

        //#endregion

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
                    dgvSummary.Visible = true;
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
