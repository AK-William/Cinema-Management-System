using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;
using TicketSelling.Entity;
using TicketSelling.UI.Configuration;
using TicketSelling.UI.FrmMessageBox;

namespace TicketSelling.UI.Report
{
    public partial class FrmTicketSellReportByDate : UserControl
    {
        ResSale res = new ResSale();
        List<SaleReport> lstSaleReport = new List<SaleReport>();
        string StartDate = "", EndDate = "";

        public FrmTicketSellReportByDate()
        {
            InitializeComponent();
        }

        private void FrmTicketSellReportByDate_Load(object sender, EventArgs e)
        {
            rbByDay.Checked = true;
            BindName();
            dgvReport.AutoGenerateColumns = false;
            CheckDataByDate();
            colorchangeseat();
            colordaynight();
        }

        #region Form Move

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Shadow Decoration 

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        #endregion

        #region theme color change

        FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        public void colorchangeseat()
        {
            if (frmmain.panelleft.BackColor == Color.FromArgb(253, 73, 131))
            {
                btnView.FillColor = Color.FromArgb(253, 73, 131);
                rbByDay.CheckedState.FillColor = Color.FromArgb(253, 73, 131);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(253, 73, 131);
                dpFromDate.FillColor = Color.FromArgb(253, 73, 131);
                dpToDate.FillColor = Color.FromArgb(253, 73, 131);
                dpToDate.FillColor = Color.FromArgb(253, 73, 131);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 120, 215))
            {
                btnView.FillColor = Color.FromArgb(0, 120, 215);
                rbByDay.CheckedState.FillColor = Color.FromArgb(0, 120, 215);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(0, 120, 215);
                dpFromDate.FillColor = Color.FromArgb(0, 120, 215);
                dpToDate.FillColor = Color.FromArgb(0, 120, 215);
                dpToDate.FillColor = Color.FromArgb(0, 120, 215);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                guna2Panel3.BorderColor = Color.FromArgb(0, 120, 215);
                guna2Panel3.ShadowDecoration.Color = Color.Pink;
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(27, 182, 211))
            {
                btnView.FillColor = Color.FromArgb(27, 182, 211);
                rbByDay.CheckedState.FillColor = Color.FromArgb(27, 182, 211);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(27, 182, 211);
                dpFromDate.FillColor = Color.FromArgb(27, 182, 211);
                dpToDate.FillColor = Color.FromArgb(27, 182, 211);
                dpToDate.FillColor = Color.FromArgb(27, 182, 211);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
                guna2Panel3.CustomBorderColor = Color.FromArgb(27, 182, 211);
                guna2Panel3.ShadowDecoration.Color = Color.FromArgb(27, 182, 211);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(123, 31, 162))
            {
                btnView.FillColor = Color.FromArgb(123, 31, 162);
                rbByDay.CheckedState.FillColor = Color.FromArgb(123, 31, 162);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(123, 31, 162);
                dpFromDate.FillColor = Color.FromArgb(123, 31, 162);
                dpToDate.FillColor = Color.FromArgb(123, 31, 162);
                dpToDate.FillColor = Color.FromArgb(123, 31, 162);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(84, 110, 122))
            {
                btnView.FillColor = Color.FromArgb(84, 110, 122);
                rbByDay.CheckedState.FillColor = Color.FromArgb(84, 110, 122);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(84, 110, 122);
                dpFromDate.FillColor = Color.FromArgb(84, 110, 122);
                dpToDate.FillColor = Color.FromArgb(84, 110, 122);
                dpToDate.FillColor = Color.FromArgb(84, 110, 122);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 200, 83))
            {
                btnView.FillColor = Color.FromArgb(0, 200, 83);
                rbByDay.CheckedState.FillColor = Color.FromArgb(0, 200, 83);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(0, 200, 83);
                dpFromDate.FillColor = Color.FromArgb(0, 200, 83);
                dpToDate.FillColor = Color.FromArgb(0, 200, 83);
                dpToDate.FillColor = Color.FromArgb(0, 200, 83);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(217, 115, 65))
            {
                btnView.FillColor = Color.FromArgb(217, 115, 65);
                rbByDay.CheckedState.FillColor = Color.FromArgb(217, 115, 65);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(217, 115, 65);
                dpFromDate.FillColor = Color.FromArgb(217, 115, 65);
                dpToDate.FillColor = Color.FromArgb(217, 115, 65);
                dpToDate.FillColor = Color.FromArgb(217, 115, 65);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 115, 65);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 115, 65);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(196, 30, 58))
            {
                btnView.FillColor = Color.FromArgb(196, 30, 58);
                rbByDay.CheckedState.FillColor = Color.FromArgb(196, 30, 58);
                rbByCustom.CheckedState.FillColor = Color.FromArgb(196, 30, 58);
                dpFromDate.FillColor = Color.FromArgb(196, 30, 58);
                dpToDate.FillColor = Color.FromArgb(196, 30, 58);
                dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
            }
        }

        public void colordaynight()
        {
            if (frmmain.panelTitle.BackColor == Color.FromArgb(41, 47, 57))
            {
                guna2Panel5.BackColor = Color.FromArgb(43, 55, 61);
                guna2Panel6.BackColor = Color.FromArgb(43, 55, 61);
                
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                lblFromDate.ForeColor = Color.White;
                lblToDate.ForeColor = Color.White;
                lblDate.ForeColor = Color.White;
                rbByCustom.ForeColor = Color.White;
                rbByDay.ForeColor = Color.White;
                cbMovie.FillColor = Color.FromArgb(45, 57, 68);
                cbMovie.ForeColor = Color.White;
                dgvReport.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvReport.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvReport.DefaultCellStyle.ForeColor = Color.White;
                dgvReport.GridColor = Color.FromArgb(41, 47, 57);
                dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvReport.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvReport.DefaultCellStyle.SelectionForeColor = Color.White;
                guna2Panel3.BackColor = Color.FromArgb(68, 87, 96);
                guna2Panel7.BackColor = Color.FromArgb(68, 87, 96);
            }
        }

        #endregion

        private void BindName()
        {
            try
            {
                cbMovie.DataSource = null;
                ResMovie res = new MovieDao().GetMovieNameForReport();
                //if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                if (res.LstMovie.Count > 0) //no data entry error control
                {
                    {
                        cbMovie.SelectedIndexChanged -= new EventHandler(CbMovie_SelectedIndexChanged);
                        cbMovie.DataSource = null;
                        cbMovie.DataSource = res.LstMovie;
                        cbMovie.DisplayMember = "Name";
                        cbMovie.ValueMember = "Id";
                        cbMovie.SelectedIndex = 0;
                        cbMovie.SelectedIndexChanged += new EventHandler(CbMovie_SelectedIndexChanged);
                    }
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                btnView.Enabled = false;
                int MovieId = Convert.ToInt32(cbMovie.SelectedValue);
                if (rbByDay.Checked)
                {
                    res = new SaleDao().GetSaleReportByDate(ProcedureConstants.SP_GetSaleReportByDate, MovieId, dpFromDate.Value);
                    lstSaleReport = res.lstSaleReport.ToList();
                    StartDate = dpFromDate.Value.ToString(Common.CommonFormat.DateFormat);
                    EndDate = "";
                }
                else
                {
                    StartDate = dpFromDate.Value.ToString(CommonFormat.DateFormat);
                    EndDate = dpToDate.Value.ToString(CommonFormat.DateFormat);
                    res = new SaleDao().GetSaleReportByDate(ProcedureConstants.SP_GetSaleReportByWeek, MovieId, dpFromDate.Value, dpToDate.Value);
                    lstSaleReport = res.lstSaleReport.ToList();
                }
                if (lstSaleReport.Count > 0)
                {
                    dgvReport.DataSource = lstSaleReport;
                    txtTotalPrice.Text = lstSaleReport.Sum(x => x.Price).ToString();
                }
                else
                {
                    FrmSuccess frm = new FrmSuccess();
                    frm.lblSuccess.Text = "No Data For This Date";
                    frm.ShowDialog();
                }
                btnView.Enabled = true;
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
                btnView.Enabled = true;
            }
        }

        private void RbByDay_CheckedChanged(object sender, EventArgs e)
        {
            CheckDataByDate();

        }

        private void CheckDataByDate()
        {
            lblFromDate.Visible = lblToDate.Visible = dpToDate.Visible = false;
            lblDate.Visible = dpFromDate.Visible = true;
            dpFromDate.CustomFormat = Common.CommonFormat.DateFormat;
            dpFromDate.MinDate = Convert.ToDateTime("1/1/1753");
            dpFromDate.MaxDate = Convert.ToDateTime("12/31/9998");
            dpToDate.MinDate = Convert.ToDateTime("1/1/1753");
            dpToDate.MaxDate = Convert.ToDateTime("12/31/9998");
            int MovieId = Convert.ToInt32(cbMovie.SelectedValue);
            ResMovieSD res = new MovieDao().GetMovieDateById(MovieId);
            if (res.LstMovieSD.Count > 0) //if condition use to control error in datetime bcoz LstMovieSD have O index 
            {
                dpFromDate.MinDate = res.LstMovieSD[0].StartDate;
                dpFromDate.MaxDate = res.LstMovieSD[0].EndDate;
                dpToDate.MinDate = res.LstMovieSD[0].StartDate;
                dpToDate.MaxDate = res.LstMovieSD[0].EndDate;
            }
            btnView.Location = new Point(402, 132);
        }


        private void RbByCustom_CheckedChanged(object sender, EventArgs e)
        {
            lblFromDate.Visible = dpFromDate.Visible = lblToDate.Visible = dpToDate.Visible = true;
            lblDate.Visible = false;
            dpFromDate.MinDate = Convert.ToDateTime("1/1/1753");
            dpFromDate.MaxDate = Convert.ToDateTime("12/31/9998");
            dpToDate.MinDate = Convert.ToDateTime("1/1/1753");
            dpToDate.MaxDate = Convert.ToDateTime("12/31/9998");
            dpFromDate.CustomFormat = Common.CommonFormat.DateFormat;
            int MovieId = Convert.ToInt32(cbMovie.SelectedValue);
            ResMovieSD res = new MovieDao().GetMovieDateById(MovieId);
            if (res.LstMovieSD.Count > 0) //if condition use to control error in datetime bcoz LstMovieSD have O index 
            {
                dpFromDate.MinDate = res.LstMovieSD[0].StartDate;
                dpFromDate.MaxDate = res.LstMovieSD[0].EndDate;
                dpToDate.MinDate = res.LstMovieSD[0].StartDate;
                dpToDate.MaxDate = res.LstMovieSD[0].EndDate;
            }
            btnView.Location = new Point(767, 132);
        }


        private void CbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dpFromDate.MinDate = Convert.ToDateTime("1/1/1753");
                dpFromDate.MaxDate = Convert.ToDateTime("12/31/9998");
                dpToDate.MinDate = Convert.ToDateTime("1/1/1753");
                dpToDate.MaxDate = Convert.ToDateTime("12/31/9998");
                int MovieId = Convert.ToInt32(cbMovie.SelectedValue);
                ResMovieSD res = new MovieDao().GetMovieDateById(MovieId);
                if (res.LstMovieSD.Count > 0) //if condition use to control error in datetime bcoz LstMovieSD have O index 
                {
                    dpFromDate.MinDate = res.LstMovieSD[0].StartDate;
                    dpFromDate.MaxDate = res.LstMovieSD[0].EndDate;

                    dpToDate.MinDate = res.LstMovieSD[0].StartDate;
                    dpToDate.MaxDate = res.LstMovieSD[0].EndDate;
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }


    }
}
