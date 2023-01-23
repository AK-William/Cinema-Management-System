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
        List<SaleReport> lstaleReport = new List<SaleReport>();
        string StartDate = "", EndDate = "";
       
        public FrmTicketSellReportByDate()
        {
            InitializeComponent();
        }

        private void FrmTicketSellReportByDate_Load(object sender, EventArgs e)
        {
            rbByDay.Checked = true;
            dpFromDate.Value = DateTime.Now;
            dpToDate.Value = DateTime.Now;
            BindName();
            
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
                    cbMovie.DataSource = null;
                    cbMovie.DataSource = res.LstMovie;
                    cbMovie.DisplayMember = "Name";
                    cbMovie.ValueMember = "Id";
                    cbMovie.SelectedIndex = 0;
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
                    res = new SaleDao().GetSaleReportByDate(ProcedureConstants.SP_GetSaleReportByDate,MovieId,dpFromDate.Value);
                    lstaleReport = res.lstSaleReport.ToList();
                    StartDate = dpFromDate.Value.ToString(Common.CommonFormat.DateFormat);
                    EndDate = "";
                }
                if (lstaleReport.Count > 0)
                {
                    FrmReportViewer frm = new FrmReportViewer(lblTitle.Text, lstaleReport, ReportNameConstants.TICKET_SELL_REPORT_BY_DATE, StartDate, EndDate);
                    frm.ShowDialog();
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
            lblFromDate.Visible = lblToDate.Visible = dpToDate.Visible = false;
            lblDate.Visible = dpFromDate.Visible = true;
            dpFromDate.CustomFormat = Common.CommonFormat.DateFormat;
            dpFromDate.Value = DateTime.Now;
        }

        private void RbByWeek_CheckedChanged(object sender, EventArgs e)
        {
            lblFromDate.Visible = lblToDate.Visible = dpToDate.Visible = false;
            lblDate.Visible = dpFromDate.Visible = true;
            dpFromDate.CustomFormat = Common.CommonFormat.DateFormat;
            dpFromDate.Value = DateTime.Now;
        }

        private void RbByMonth_CheckedChanged(object sender, EventArgs e)
        {
            lblFromDate.Visible = lblToDate.Visible = dpToDate.Visible = false;
            lblDate.Visible = dpFromDate.Visible = true;
            dpFromDate.Format = DateTimePickerFormat.Custom;
            dpFromDate.CustomFormat = Common.CommonFormat.MonthFormat;
        }

        private void RbByCustom_CheckedChanged(object sender, EventArgs e)
        {
            lblFromDate.Visible = dpFromDate.Visible = lblToDate.Visible = dpToDate.Visible = true;
            lblDate.Visible =  false;
            dpFromDate.CustomFormat = Common.CommonFormat.DateFormat;
            dpFromDate.Value = DateTime.Now;
        }

        

    }
}
