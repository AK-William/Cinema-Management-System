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
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;
using TicketSelling.Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.IO;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Style;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmTicketBuyerInformation : Form
    {
        List<Seat> lstSeat = new List<Seat>();
        List<Seat> lstCustomerSeat = new List<Seat>();
        MovieST movieST = new MovieST();
        List<SaleDetail> lstDetail = new List<SaleDetail>();

        public FrmTicketBuyerInformation(List<Seat> lst, List<Seat> _lstCustomerSeat, MovieST _movieST)
        {
            InitializeComponent();
            lstSeat = lst;
            lstCustomerSeat = _lstCustomerSeat;
            movieST = _movieST;
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmTicketBuyerInformation_Load(object sender, EventArgs e)
        {
            var lst = new List<Seat>();

            if (lstSeat.Count > 0)
            {
                if (lstCustomerSeat.Count > 0)
                {
                    for (int i = 0; i < lstCustomerSeat.Count; i++)
                    {
                        var item = lstCustomerSeat[i];
                        int index = lstSeat.FindIndex(x => x.Id == item.Id);
                        lstSeat.RemoveAt(index);
                    }
                    txtPrice.Text = lstSeat.Sum(x => x.Price).ToString();
                }
                else
                {
                    txtPrice.Text = lstSeat.Sum(x => x.Price).ToString();
                }
            }

            for (int i = 0; i < lstSeat.Count; i++)
            {
                var item = lstSeat[i];
                lstDetail.Add(new SaleDetail()
                {
                    SeatTypeId = item.SeatTypeId,
                    SeatId = item.Id,
                    Price = item.Price,
                });

            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                if (lstDetail.Count == 0)
                {
                    FrmMessageBox.FrmWarning fmS = new FrmMessageBox.FrmWarning();
                    fmS.lblWarning.Text = "Please, Choose Seat";
                    fmS.ShowDialog();
                    return;
                }
                MessageEntity res = new SaleDao().SaveSaleData(1, new SaleHead()
                {
                    MovieId = movieST.MovieId,
                    MovieDate = movieST.Date,
                    MovieTime = movieST.Time,
                    CustomerName = txtName.Text,
                    Phone = txtPhoneNumber.Text,
                    TotalPrice = Convert.ToInt32(txtPrice.Text),
                    lstSaleDetail = lstDetail
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    FrmMessageBox.FrmSuccess fmS = new FrmMessageBox.FrmSuccess();
                    fmS.lblSuccess.Text = "Saving Successfully";
                    fmS.ShowDialog();
                    PrintData(res.HeadId);
                    this.Close();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                        fmW.lblWarning.Text = "Username already exist! Please enter another username";
                        fmW.ShowDialog();
                    }
                    else
                    {
                        FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                        fmE.lblError.Text = "Save Fail! Please recheck entered information";
                        fmE.ShowDialog();
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

        public void PrintData(int HeadId)
        {
            try
            {
                string SeatName = string.Empty;
                ResTicketData res = new SaleDao().GetTicketData(HeadId);
                if (res.lstTicketData != null && res.lstTicketData.Count > 0)
                {
                    for (int i = 0; i < res.lstTicketData.Count; i++)
                    {
                        var item = res.lstTicketData[i];
                        SeatName += "," + item.SeatName;
                    }
                    SeatName = SeatName.Substring(1, SeatName.Length - 1);
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        //Set some properties of the Excel document
                        excelPackage.Workbook.Properties.Author = "VDWWD";
                        excelPackage.Workbook.Properties.Title = "Title of Document";
                        excelPackage.Workbook.Properties.Subject = "EPPlus demo export data";
                        excelPackage.Workbook.Properties.Created = DateTime.Now;
                        //Create the WorkSheet
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
                        worksheet.Cells["A1:C1"].Style.Font.Color.SetColor(Color.FromArgb(0, 124, 183));
                        worksheet.Cells["A1:C1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["A1:C1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(232, 235, 249));
                        worksheet.Cells["A1:C1"].Style.Font.Bold = true;
                        worksheet.Cells["A1:C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        //Add some text to cell A1
                        worksheet.Cells["A1:C1"].Value = "CINEMA TICKET";
                        worksheet.Cells["A1:C1"].Merge = true;
                        worksheet.Cells["A3"].Value = "Name :";
                        worksheet.Cells["B3"].Value = res.lstTicketData[0].CustomerName;
                        worksheet.Cells["A4"].Value = "Phone No :";
                        worksheet.Cells["B4"].Value = res.lstTicketData[0].Phone;
                        worksheet.Cells["A5"].Value = "Movie Name :";
                        worksheet.Cells["B5"].Value = res.lstTicketData[0].MovieName;
                        worksheet.Cells["A6"].Value = "Movie Date :";
                        worksheet.Cells["B6"].Value = res.lstTicketData[0].StrMovieDate;
                        worksheet.Cells["A7"].Value = "Movie Time :";
                        worksheet.Cells["B7"].Value = res.lstTicketData[0].MovieTime;
                        worksheet.Cells["A8"].Value = "Seat :";
                        worksheet.Cells["B8"].Value = SeatName;
                        worksheet.Cells["A9"].Value = "Total Amount :";
                        worksheet.Cells["B9"].Value = res.lstTicketData[0].TotalPrice;
                        worksheet.Cells["A11:C11"].Value = "THANK YOU";
                        worksheet.Cells["A11:C11"].Merge = true;
                        worksheet.Cells["A11:A11"].Style.Font.Bold = true;
                        worksheet.Cells["A11:A11"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        //Save your file
                        string ExportPath = AppDomain.CurrentDomain.BaseDirectory + @"ExportData\1.xlsx";
                        FileInfo fi = new FileInfo(ExportPath);
                        excelPackage.SaveAs(fi);
                        System.Diagnostics.Process.Start(ExportPath);
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

    }
}
