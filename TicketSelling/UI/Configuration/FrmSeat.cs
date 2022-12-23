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
        }

        #region SeatType

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtSeatTypeName.Text))
            {
                MessageBox.Show("Enter Seat Type");
                return false;
            }
            if (string.IsNullOrEmpty(txtSeatTypeNote.Text))
            {
                MessageBox.Show("Enter comment");
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
                    MessageBox.Show("Success");
                    Reset();
                    BindDgvData();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmSeat_Load(object sender, EventArgs e)
        {
            BindDgvData();
            BindDgvSeat();
            txtSeatTypeName.Focus();
        }

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
                int SeatCount = new SeatTypeDao().CheckSeatBySeatTypeId(Convert.ToInt32(dgvSeatType.Rows[e.RowIndex].Cells["ColIdSeatType"].Value));//Control delete seattype when seats are assign
                if (SeatCount > 0)
                {
                    MessageBox.Show("Transaction Exists");
                    return;
                }
                else
                {
                    if (dgvSeatType.Rows[e.RowIndex].Cells["ColDelSeatType"].ColumnIndex == e.ColumnIndex)
                    {
                        DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            MessageEntity res1 = new SeatTypeDao().DeleteSeatType(Convert.ToInt32(dgvSeatType.Rows[e.RowIndex].Cells["ColIdSeatType"].Value));
                            if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                            {
                                MessageBox.Show("Delete Success");
                                Reset();
                                BindDgvData();
                            }
                            else if (res1.RespMessageType == CommonResponseMessage.ResErrorType)
                            {
                                MessageBox.Show("Delete Fail");
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    MessageBox.Show("Update Success");
                    Reset();
                    BindDgvData();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
                MessageBox.Show("Enter Number of Seats");
                return false;
            }
            if (string.IsNullOrEmpty(txtSeatPrice.Text))
            {
                MessageBox.Show("Enter Seats Price");
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
                    MessageBox.Show("Success");
                    ResetSeat();
                    BindDgvSeat();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
                MessageBox.Show(ex.Message);
            }
        }

        int idseat = -1; int SeatTypeId;

        private void DgvSeat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    MessageBox.Show("Update Success");
                    Reset();
                    BindDgvSeat();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DgvSeat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSeat.Rows[e.RowIndex].Cells["ColDelSeat"].ColumnIndex == e.ColumnIndex)
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        MessageEntity res1 = new SeatDao().DeleteSeat(Convert.ToInt32(dgvSeat.Rows[e.RowIndex].Cells["ColId"].Value));
                        if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show("Delete Success");
                            Reset();
                            BindDgvSeat();
                        }
                        else if (res1.RespMessageType == CommonResponseMessage.ResErrorType)
                        {
                            MessageBox.Show("Delete Fail");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        
    }
}
    