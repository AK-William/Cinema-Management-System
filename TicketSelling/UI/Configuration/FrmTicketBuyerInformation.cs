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

    }
}
