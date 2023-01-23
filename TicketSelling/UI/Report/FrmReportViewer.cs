using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.Entity;
using TicketSellingManagementSystem.Report.RPT;

namespace TicketSelling.UI.Report
{
    public partial class FrmReportViewer : Form
    {
        List<SaleReport> lstSaleReport = new List<SaleReport>();
        string startDate=string.Empty, endDate = string.Empty;

        public FrmReportViewer()
        {
            InitializeComponent();
        }

        public FrmReportViewer(string Formtitle, List<SaleReport> _LstSaleReport, string reportName, string StartDate, string EndDate)
        {
            InitializeComponent();
            lblTitle.Text = Formtitle;
            lstSaleReport = _LstSaleReport;

            startDate = StartDate;
            endDate = EndDate;
            if (reportName == ReportNameConstants.TICKET_SELL_REPORT_BY_DATE)
            {
                GetTicketSaleReportByDate();
            }
        }

        private void GetTicketSaleReportByDate()
        {
            ReportClass rpt = new CashInSummaryReport();

           
            ParameterFields lstPayableReport = new ParameterFields();

            //ParameterField pf1 = new ParameterField();
            //ParameterDiscreteValue disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "Amount";
            //disvalue1.Value = Amount;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);


            //pf1 = new ParameterField();
            //disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "AccountDescription";
            //disvalue1.Value = AccDescription;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);

            //pf1 = new ParameterField();
            //disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "RecordNo";
            //disvalue1.Value = RecordNo;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);

            //pf1 = new ParameterField();
            //disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "Total";
            //disvalue1.Value = Total;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);

            //pf1 = new ParameterField();
            //disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "GrandTotal";
            //disvalue1.Value = GrandTotal;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);

            //pf1 = new ParameterField();
            //disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "DateTo";
            //disvalue1.Value = DateTo;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);

            //pf1 = new ParameterField();
            //disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "DateFrom";
            //disvalue1.Value = DateFrom;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);

            //pf1 = new ParameterField();
            //disvalue1 = new ParameterDiscreteValue();
            //pf1.Name = "CreatedDate";
            //disvalue1.Value = CreatedDate;
            //pf1.CurrentValues.Add(disvalue1);
            //lstPayableReport.Add(pf1);


            crystalReportViewer.ParameterFieldInfo = lstPayableReport;
            crystalReportViewer.EnableDrillDown = false;
            rpt.SetDataSource(lstSaleReport);

            rpt.SetParameterValue("sd", startDate);
            rpt.SetParameterValue("ed", endDate);
            crystalReportViewer.ReportSource = rpt;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
