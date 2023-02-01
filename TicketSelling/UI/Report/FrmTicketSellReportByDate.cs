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

        private void BindName()
        {
            try
            {
                cbMovie.DataSource = null;
                ResMovie res = new MovieDao().GetMovieNameForReport();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
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
