using Guna.UI2.WinForms;
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

namespace TicketSelling.UI.Configuration
{
    public partial class FrmTicketSell : UserControl
    {
        List<Seat> lstSeat = new List<Seat>();
        int X = 40, Y = 20;
        string SeatId = string.Empty;
        List<Seat> lstSeatId = new List<Seat>();
        List<Seat> lstCustomerSeat = new List<Seat>();
        Color originalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        Color selectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(250)))), ((int)(((byte)(154)))));
        Color ExistColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));


        public FrmTicketSell()
        {
            InitializeComponent();
        }

        private void FrmTicketSell_Load(object sender, EventArgs e)
        {
            BindName();
            BindSeat();
            CreateSeat();
            colorchangeseat();
            colordaynight();
        }

        #region theme color change

        FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        public void colorchangeseat()
        {
            if (frmmain.panelleft.BackColor == Color.FromArgb(253, 73, 131))
            {
                btnCheck.BackColor = Color.FromArgb(253, 73, 131);
                dpMovieDate.FillColor = Color.FromArgb(253, 73, 131);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 120, 215))
            {
                btnCheck.BackColor = Color.FromArgb(0, 120, 215);
                dpMovieDate.FillColor = Color.FromArgb(0, 120, 215);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(27, 182, 211))
            {
                btnCheck.BackColor = Color.FromArgb(27, 182, 211);
                dpMovieDate.FillColor = Color.FromArgb(27, 182, 211);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(123, 31, 162))
            {
                btnCheck.BackColor = Color.FromArgb(123, 31, 162);
                dpMovieDate.FillColor = Color.FromArgb(123, 31, 162);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(84, 110, 122))
            {
                btnCheck.BackColor = Color.FromArgb(84, 110, 122);
                dpMovieDate.FillColor = Color.FromArgb(84, 110, 122);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 200, 83))
            {
                btnCheck.BackColor = Color.FromArgb(0, 200, 83);
                dpMovieDate.FillColor = Color.FromArgb(0, 200, 83);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(217, 115, 65))
            {
                btnCheck.BackColor = Color.FromArgb(217, 115, 65);
                dpMovieDate.FillColor = Color.FromArgb(217, 115, 65);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(196, 30, 58))
            {
                btnCheck.BackColor = Color.FromArgb(196, 30, 58);
                dpMovieDate.FillColor = Color.FromArgb(196, 30, 58);
            }
        }

        public void colordaynight()
        {
            if (frmmain.panelTitle.BackColor == Color.FromArgb(41, 47, 57))
            {
                panelTop.BackColor = Color.FromArgb(43, 55, 61);
                panelMid.BackColor = Color.FromArgb(43, 55, 61);
                panelBot.BackColor = Color.FromArgb(43, 55, 61);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                cboMovieName.FillColor = Color.FromArgb(45, 57, 68);
                cboMovieName.ForeColor = Color.White;
                cboTime.FillColor = Color.FromArgb(45, 57, 68);
                cboTime.ForeColor = Color.White;
                //dgvSeatType.BackgroundColor = Color.FromArgb(68, 87, 96);
                //dgvSeatType.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                //dgvSeatType.DefaultCellStyle.ForeColor = Color.White;
                //dgvSeatType.GridColor = Color.FromArgb(41, 47, 57);
                //dgvSeatType.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                //dgvSeatType.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                //dgvSeatType.DefaultCellStyle.SelectionForeColor = Color.White;

                //tabSeat.BackColor = Color.FromArgb(43, 55, 61);
                //lblSeatname.ForeColor = Color.White;
                //lblnote.ForeColor = Color.White;
                //lblnumberofseats.ForeColor = Color.White;
                //lblprice.ForeColor = Color.White;
                //cbSeatType.FillColor = Color.FromArgb(45, 57, 68);
                //txtSeatNote.FillColor = Color.FromArgb(45, 57, 68);
                //txtNumberOfSeats.FillColor = Color.FromArgb(45, 57, 68);
                //txtSeatPrice.FillColor = Color.FromArgb(45, 57, 68);
                //cbSeatType.ForeColor = Color.White;
                //txtSeatNote.ForeColor = Color.White;
                //txtNumberOfSeats.ForeColor = Color.White;
                //txtSeatPrice.ForeColor = Color.White;
                //dgvSeat.BackgroundColor = Color.FromArgb(68, 87, 96);
                //dgvSeat.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                //dgvSeat.DefaultCellStyle.ForeColor = Color.White;
                //dgvSeat.GridColor = Color.FromArgb(41, 47, 57);
                //dgvSeat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                //dgvSeat.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                //dgvSeat.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                guna2Panel1.BackColor = Color.White;
            }
        }

        #endregion

        private void BindName()
        {
            try
            {
                cboMovieName.DataSource = null;
                ResMovie res = new MovieDao().GetMovieName();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    cboMovieName.SelectedIndexChanged -= new EventHandler(CboMovieName_SelectedIndexChanged);
                    cboMovieName.DataSource = null;
                    cboMovieName.DataSource = res.LstMovie;
                    cboMovieName.DisplayMember = "Name";
                    cboMovieName.ValueMember = "Id";
                    cboMovieName.SelectedIndex = 0;
                    cboMovieName.SelectedIndexChanged += new EventHandler(CboMovieName_SelectedIndexChanged);
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        private void CboDate_ValueChanged(object sender, EventArgs e)
        {
            BindMovieTime();
        }

        private void CboMovieName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dpMovieDate.MinDate = Convert.ToDateTime("1/1/1753");
                dpMovieDate.MaxDate = Convert.ToDateTime("12/31/9998");
                int MovieId = Convert.ToInt32(cboMovieName.SelectedValue);
                ResMovieSD res = new MovieDao().GetMovieDateById(MovieId);
                if (res.LstMovieSD.Count > 0) //if condition use to control error in datetime bcoz LstMovieSD have O index 
                {
                    dpMovieDate.MinDate = res.LstMovieSD[0].StartDate;
                    dpMovieDate.MaxDate = res.LstMovieSD[0].EndDate;
                    dpMovieDate.Value = res.LstMovieSD[0].StartDate;
                    BindMovieTime();
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        private void BindMovieTime()
        {
            try
            {
                cboTime.DataSource = null;
                int MovieId = Convert.ToInt32(cboMovieName.SelectedValue);
                ResMovieST res = new MovieDao().GetMovieTimeByDateForTicket(MovieId, Convert.ToDateTime(dpMovieDate.Value));
                if (res.LstMovieST.Count > 0)  //no data entry error control
                {
                    cboTime.SelectedIndexChanged -= new EventHandler(CboTime_SelectedIndexChanged);
                    cboTime.DataSource = res.LstMovieST;
                    cboTime.DisplayMember = "Time";
                    cboTime.ValueMember = "Id";
                    cboTime.SelectedIndex = 0;
                    cboTime.SelectedIndexChanged += new EventHandler(CboTime_SelectedIndexChanged);
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        public void BindSeat()
        {
            try
            {
                ResSeat res = new SeatDao().GetAllSeatForTicket();
                if (res.LstSeat.Count > 0)
                {
                    lstSeat = res.LstSeat;
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        public void CreateSeat()
        {
            try
            {
                for (int i = 0; i < lstSeat.Count; i++)
                {
                    var item = lstSeat[i];
                    Guna2Button btnSeat = new Guna2Button();
                    var res = lstSeatId.Where(x => x.Id == item.Id).FirstOrDefault(); //Color selection change 
                    var res1 = lstCustomerSeat.Where(x => x.Id == item.Id).FirstOrDefault();
                    btnSeat.BorderThickness = 1;
                    btnSeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                    btnSeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                    btnSeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                    btnSeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                    btnSeat.FillColor = (res == null) ? originalColor : selectionColor;
                    if (res1 != null)
                    {
                        btnSeat.FillColor = ExistColor;
                    }
                    btnSeat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnSeat.ForeColor = System.Drawing.Color.Black;
                    btnSeat.Location = new System.Drawing.Point(X, Y);
                    btnSeat.Name = item.Price.ToString();
                    btnSeat.Tag = item.SeatTypeId + "," + item.Id;
                    btnSeat.ShadowDecoration.BorderRadius = 3;
                    btnSeat.ShadowDecoration.Depth = 10;
                    btnSeat.ShadowDecoration.Enabled = true;
                    btnSeat.Size = new System.Drawing.Size(82, 80);
                    btnSeat.TabIndex = 0;
                    btnSeat.Text = item.Name;
                    btnSeat.Click += new EventHandler(BtnSeat_Click);
                    panelMid.Controls.Add(btnSeat);
                    X += btnSeat.Width + 20;
                    if ((i + 1) % item.NumberOfSeat == 0)
                    {
                        X = 40;
                        if (item.SeatTypeId != item.SeatTypeId)
                        {
                            Y += btnSeat.Height + 15;
                        }
                        else
                        {
                            Y += btnSeat.Height + 15;
                        }
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

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            try
            {
                Guna2Button btn = sender as Guna2Button;
                if (btn.FillColor == ExistColor)
                {
                    FrmMessageBox.FrmWarning FrW = new FrmMessageBox.FrmWarning();
                    FrW.lblWarning.Text = "This seat has been already bought";
                    FrW.ShowDialog();
                }
                string IdAndTypeId = ((Guna2Button)sender).Tag.ToString();
                string[] strArray = new string[2];
                strArray = IdAndTypeId.Split(',');
                int typeId = Convert.ToInt32(strArray[0]);
                int id = Convert.ToInt32(strArray[1]);
                int price = Convert.ToInt32(((Guna2Button)sender).Name);
                if (btn.FillColor == selectionColor)
                {
                    int index = lstSeatId.FindIndex(x => x.Id == id);
                    btn.FillColor = originalColor;
                    lstSeatId.RemoveAt(index);
                }
                else
                {
                    if (btn != null)
                    {
                        lstSeatId.Add(new Seat() { SeatTypeId = typeId, Id = id, Price = price });
                    }

                }
                panelMid.Controls.Clear();
                X = 40; Y = 20;
                CreateSeat();
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboTime.Text.ToString()))
            {
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please choose movie name and movie date";
                fmW.ShowDialog();
                return;
            }
            if (cboTime.Text == "--Select One--")
            {
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please choose movie time";
                fmW.ShowDialog();
                return;
            }
            if (lstSeat.Count > 0)
            {
                MovieST movieST = new MovieST();
                movieST.MovieId = Convert.ToInt32(cboMovieName.SelectedValue);
                movieST.Date = Convert.ToDateTime(dpMovieDate.Value);
                movieST.Time = cboTime.SelectedValue.ToString();

                if (lstSeatId.Count == 0)
                {
                    FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                    fmW.lblWarning.Text = "Please choose seat";
                    fmW.ShowDialog();
                    return;
                }
                FrmTicketBuyerInformation frm = new FrmTicketBuyerInformation(lstSeatId, lstCustomerSeat, movieST);
                frm.ShowDialog();
                GetSellingTicket();
            }
        }

        private void CboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetSellingTicket();
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        private void GetSellingTicket()
        {
            try
            {
                lstSeatId = new List<Seat>();
                List<Seat> lstTmpCustomerSeat = new List<Seat>();
                ResSale res = new SaleDao().GetSellingTicket(Convert.ToInt32(cboMovieName.SelectedValue), Convert.ToDateTime(dpMovieDate.Value), Convert.ToInt32(cboTime.SelectedValue));
                if (res.lstSaleDetail.Count > 0)
                {
                    for (int i = 0; i < res.lstSaleDetail.Count; i++)
                    {
                        var item = res.lstSaleDetail[i];
                        lstSeatId.Add(new Seat() { SeatTypeId = item.SeatTypeId, Id = item.SeatId, Price = item.Price });
                        lstTmpCustomerSeat.Add(new Seat() { SeatTypeId = item.SeatTypeId, Id = item.SeatId, Price = item.Price });
                    }
                }
                lstCustomerSeat = lstTmpCustomerSeat;
                panelMid.Controls.Clear();
                X = 40; Y = 20;
                CreateSeat();

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

