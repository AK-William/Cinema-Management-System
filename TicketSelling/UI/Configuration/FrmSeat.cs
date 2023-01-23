using TicketSelling.DAO;
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
using TicketSelling.DAO.Entity;
using TicketSelling.UI.FrmMessageBox;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmSeat : UserControl
    {
        public FrmSeat()
        {
            InitializeComponent();
            dgvSeatType.AutoGenerateColumns = false;
            dgvSeat.AutoGenerateColumns = false;
            this.dgvSeat.Columns["ColPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colorchangeseat();
            colordaynight();
        }

        #region SeatType

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtSeatTypeName.Text))
            {
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please enter Seat Type Name";
                fmW.ShowDialog();
                return false;
            }
            if (string.IsNullOrEmpty(txtSeatTypeNote.Text))
            {
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please enter comment for Seat";
                fmW.ShowDialog();
                return false;
            }
            return true;
        }

        private void SaveData()
        {
            try
            {
                if (!CheckRequireFields()) return;
                MessageEntity res = new SeatTypeDao().SaveSeatType(1, new DAO.Entity.SeatType()
                {
                    Name = txtSeatTypeName.Text,
                    Note = txtSeatTypeNote.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    FrmMessageBox.FrmNormal fmN = new FrmMessageBox.FrmNormal();
                    fmN.lblNormal.Text = "Seat type name was saved!";
                    fmN.ShowDialog();
                    Reset();
                    BindDgvData();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                        fmW.lblWarning.Text = "Seat type name already exists";
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

        private void BtnSeatTypeSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void BindDgvData()
        {
            try
            {
                dgvSeatType.DataSource = null;
                ResSeatType res = new SeatTypeDao().GetAllSeatType();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvSeatType.DataSource = res.LstSeatType;
                    LstSeatType = res.LstSeatType; //forRoomComboBox
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }


        private void FrmSeat_Load(object sender, EventArgs e)
        {
            BindDgvData();
            BindDgvSeat();
            txtSeatTypeName.Focus();
        }

        #region theme color change

        FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        public void colorchangeseat()
        {
            if (frmmain.panelleft.BackColor == Color.FromArgb(253, 73, 131))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 120, 215))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(27, 182, 211))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(123, 31, 162))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(84, 110, 122))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 200, 83))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(217, 115, 65))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 115, 65);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 115, 65);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 115, 65);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 115, 65);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(196, 30, 58))
            {
                dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvSeatType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
                dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvSeat.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
            }
        }

        public void colordaynight()
        {
            if (frmmain.panelTitle.BackColor == Color.FromArgb(41, 47, 57))
            {
                tabSeatType.BackColor = Color.FromArgb(43, 55, 61);
                lblseattypename.ForeColor = Color.White;
                lblseattypenote.ForeColor = Color.White;
                txtSeatTypeName.FillColor = Color.FromArgb(45, 57, 68);
                txtSeatTypeName.ForeColor = Color.White;
                txtSeatTypeNote.FillColor = Color.FromArgb(45, 57, 68);
                txtSeatTypeNote.ForeColor = Color.White;
                dgvSeatType.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvSeatType.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvSeatType.DefaultCellStyle.ForeColor = Color.White;
                dgvSeatType.GridColor = Color.FromArgb(41, 47, 57);
                dgvSeatType.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvSeatType.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvSeatType.DefaultCellStyle.SelectionForeColor = Color.White;

                tabSeat.BackColor = Color.FromArgb(43, 55, 61);
                lblSeatname.ForeColor = Color.White;
                lblnote.ForeColor = Color.White;
                lblnumberofseats.ForeColor = Color.White;
                lblprice.ForeColor = Color.White;
                cbSeatType.FillColor = Color.FromArgb(45, 57, 68);
                txtSeatNote.FillColor = Color.FromArgb(45, 57, 68);
                txtNumberOfSeats.FillColor = Color.FromArgb(45, 57, 68);
                txtSeatPrice.FillColor = Color.FromArgb(45, 57, 68);
                cbSeatType.ForeColor = Color.White;
                txtSeatNote.ForeColor = Color.White;
                txtNumberOfSeats.ForeColor = Color.White;
                txtSeatPrice.ForeColor = Color.White;
                dgvSeat.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvSeat.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvSeat.DefaultCellStyle.ForeColor = Color.White;
                dgvSeat.GridColor = Color.FromArgb(41, 47, 57);
                dgvSeat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvSeat.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvSeat.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                tabSeatType.BackColor = Color.White;
                lblseattypename.ForeColor = Color.Black;
                lblseattypenote.ForeColor = Color.Black;
            }
        }

        #endregion

        private void Reset()
        {
            txtSeatTypeName.Text = "";
            txtSeatTypeNote.Text = "";
            txtSeatTypeName.Focus();
            btnSeatTypeUpdate.Visible = false;
            btnSeatTypeSave.Visible = true;
        }

        private void BtnSeatTypeCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void TxtSeatTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void TxtSeatTypeNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSeatTypeSave.Focus();
            }
        }

        private void TxtSeatTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DgvSeatType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSeatType.Rows[e.RowIndex].Cells["ColDelSeatType"].ColumnIndex == e.ColumnIndex) //Control delete button only in delete delete column
                {
                    int SeatCount = new SeatTypeDao().CheckSeatBySeatTypeId(Convert.ToInt32(dgvSeatType.Rows[e.RowIndex].Cells["ColIdSeatType"].Value));//Control delete seattype when seats are assign
                    if (SeatCount > 0)
                    {
                        FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                        fmE.lblError.Text = "Transaction Exists! This action cannot be done.";
                        fmE.ShowDialog();
                        return;
                    }
                    else
                    {

                        FrmDelete frm = new FrmDelete("Are you sure you want to Delete?", "Delete", true);
                        frm.ShowDialog();
                        if (frm.isYesOrNo)
                        {
                            MessageEntity res1 = new SeatTypeDao().DeleteSeatType(Convert.ToInt32(dgvSeatType.Rows[e.RowIndex].Cells["ColIdSeatType"].Value));
                            if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                            {
                                FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                                fmE.lblError.Text = "Delete Successful";
                                fmE.ShowDialog();
                                Reset();
                                BindDgvData();
                            }
                            else if (res1.RespMessageType == CommonResponseMessage.ResErrorType)
                            {
                                FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                                fmE.lblError.Text = "Delete Fail! Please recheck entered information";
                                fmE.ShowDialog();
                            }
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

        private void BtnSeatTypeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckRequireFields()) return;
                MessageEntity res = new SeatTypeDao().UpdateSeatType(1, new DAO.Entity.SeatType()
                {
                    Id = id,
                    Name = txtSeatTypeName.Text,
                    Note = txtSeatTypeNote.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    FrmMessageBox.FrmSuccess fmS = new FrmMessageBox.FrmSuccess();
                    fmS.lblSuccess.Text = "Your changes have been successfully saved!";
                    fmS.ShowDialog();
                    Reset();
                    BindDgvData();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                        fmW.lblWarning.Text = "Seat type name already exists";
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

        int id = -1;
        private void DgvSeatType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRowST = dgvSeatType.SelectedRows[0];
            id = Convert.ToInt32(dgvRowST.Cells["ColIdSeatType"].Value);
            txtSeatTypeName.Text = dgvRowST.Cells["ColSeatTypeName"].Value.ToString();
            txtSeatTypeNote.Text = dgvRowST.Cells["ColSeatTypeNote"].Value.ToString();
            btnSeatTypeSave.Visible = false;
            btnSeatTypeUpdate.Visible = true;
        }

        #endregion


        #region Seat

        private void TxtNumberOfSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSeatPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ResetSeat()
        {
            txtNumberOfSeats.Text = "";
            txtSeatPrice.Text = "";
            txtSeatNote.Text = "";
            cbSeatType.Text = null;
            btnSeatSave.Visible = true;
            btnSeatUpdate.Visible = false;
        }

        private void BtnSeatCancel_Click(object sender, EventArgs e)
        {
            ResetSeat();
        }

        public List<SeatType> LstSeatType { get; set; } //forSeatComboBox

        private void TabcontrolSeat_Click(object sender, EventArgs e)
        {
            cbSeatType.SelectedIndexChanged -= new EventHandler(CbSeatType_SelectedIndexChanged);
            cbSeatType.DataSource = null;
            cbSeatType.DataSource = LstSeatType;
            cbSeatType.DisplayMember = "Name";
            cbSeatType.ValueMember = "Id";
            cbSeatType.SelectedIndex = 0;
            cbSeatType.SelectedIndexChanged += new EventHandler(CbSeatType_SelectedIndexChanged);
            BindDgvData();
        }

        private void CbSeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SeatTypeId = Convert.ToInt32(cbSeatType.SelectedValue);
            ResSeatType res = new SeatTypeDao().GetSTNoteById(SeatTypeId);
            if (res.LstSeatType.Count > 0)
            {
                txtSeatNote.Text = res.LstSeatType[0].Note;
            }
        }

        private bool CheckRequireFieldsSeat()
        {
            if (string.IsNullOrEmpty(txtNumberOfSeats.Text))
            {
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please enter number of seats";
                fmW.ShowDialog();
                return false;
            }
            if (string.IsNullOrEmpty(txtSeatPrice.Text))
            {
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please enter seat Price";
                fmW.ShowDialog();
                return false;
            }
            return true;
        }

        private void SaveSeat()
        {
            try
            {
                if (!CheckRequireFieldsSeat()) return;
                MessageEntity res = new SeatDao().SaveSeat(1, new DAO.Entity.Seat()
                {
                    SeatTypeId = Convert.ToInt32(cbSeatType.SelectedValue),
                    SeatTypeName = cbSeatType.Text,
                    NumberOfSeat = Convert.ToInt32(txtNumberOfSeats.Text),
                    Price = Convert.ToInt32(txtSeatPrice.Text),
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    FrmMessageBox.FrmNormal fmN = new FrmMessageBox.FrmNormal();
                    fmN.lblNormal.Text = "Seat data was saved!";
                    fmN.ShowDialog();
                    ResetSeat();
                    BindDgvSeat();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                        fmW.lblWarning.Text = "Seat already Exists";
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

        private void BtnSeatSave_Click(object sender, EventArgs e)
        {
            SaveSeat();
        }

        private void BindDgvSeat()
        {
            try
            {
                dgvSeat.DataSource = null;
                ResSeat res = new SeatDao().GetAllSeat();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvSeat.DataSource = res.LstSeat;
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }
        }

        int idseat = -1; int SeatTypeId;

        private void DgvSeat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SeatCount = new SeatTypeDao().CheckCustomerSeatById(Convert.ToInt32(dgvSeat.Rows[e.RowIndex].Cells["ColTypeId"].Value));//Control update seat when  ticket are selling
            if (SeatCount > 0)
            {
                FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                fmE.lblError.Text = "Transaction Exists! This action cannot be done.";
                fmE.ShowDialog();
                return;
            }
            else
            {
                DataGridViewRow dgvRow = dgvSeat.SelectedRows[0];
                idseat = Convert.ToInt32(dgvRow.Cells["ColId"].Value);
                cbSeatType.SelectedValue = Convert.ToInt32(dgvRow.Cells["ColTypeId"].Value.ToString());
                SeatTypeId = Convert.ToInt32(dgvRow.Cells["ColTypeId"].Value.ToString());
                int NumberOfSeat = new SeatDao().GetNumberOfSeatBySeatTypeId(Convert.ToInt32(dgvRow.Cells["ColTypeId"].Value.ToString()));
                txtNumberOfSeats.Text = NumberOfSeat.ToString();
                txtSeatPrice.Text = dgvRow.Cells["ColPrice"].Value.ToString();
                btnSeatSave.Visible = false;
                btnSeatUpdate.Visible = true;
            }
        }

        private void BtnSeatUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckRequireFieldsSeat()) return;
                MessageEntity res = new SeatDao().UpdateSeat(1, new DAO.Entity.Seat()
                {
                    SeatTypeId = SeatTypeId,
                    SeatTypeName = cbSeatType.Text,
                    NumberOfSeat = Convert.ToInt32(txtNumberOfSeats.Text),
                    Price = Convert.ToInt32(txtSeatPrice.Text),
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    FrmMessageBox.FrmSuccess fmS = new FrmMessageBox.FrmSuccess();
                    fmS.lblSuccess.Text = "Your changes have been successfully saved!";
                    fmS.ShowDialog();
                    Reset();
                    BindDgvSeat();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                        fmW.lblWarning.Text = "Seat name already exists!";
                        fmW.ShowDialog();
                    }
                    else
                    {
                        FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                        fmE.lblError.Text = "Update Fail! Please recheck entered information";
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

        private void DgvSeat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSeat.Rows[e.RowIndex].Cells["ColDelSeat"].ColumnIndex == e.ColumnIndex)
                {
                    int SeatCount = new SeatTypeDao().CheckCustomerSeatById(Convert.ToInt32(dgvSeat.Rows[e.RowIndex].Cells["ColTypeId"].Value));//Control delete seat when ticket are selling
                    if (SeatCount > 0)
                    {
                        FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                        fmE.lblError.Text = "Transaction Exists! This action cannot be done.";
                        fmE.ShowDialog();
                        return;
                    }
                    else
                    {
                        FrmDelete frm = new FrmDelete("Are you sure you want to Delete?", "Delete", true);
                        frm.ShowDialog();
                        if (frm.isYesOrNo)
                        {
                            MessageEntity res1 = new SeatDao().DeleteSeat(Convert.ToInt32(dgvSeat.Rows[e.RowIndex].Cells["ColId"].Value));
                            if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                            {
                                FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                                fmE.lblError.Text = "Delete successful";
                                fmE.ShowDialog();
                                Reset();
                                BindDgvSeat();
                            }
                            else if (res1.RespMessageType == CommonResponseMessage.ResErrorType)
                            {
                                FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                                fmE.lblError.Text = "Delete Fail! Please recheck entered information";
                                fmE.ShowDialog();
                            }
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

        #endregion


    }
}
