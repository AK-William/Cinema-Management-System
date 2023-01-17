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
using System.Text.RegularExpressions;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmUser : UserControl
    {
       
        public FrmUser()
        {
            InitializeComponent();
            txtName.Select();
            dgvStaff.AutoGenerateColumns = false;
            colorchangestaff();
            colordaynight();
        }

        private void Reset()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPhoneNumber.Text = "";
            txtGmail.Text = "";
            btnRegister.Visible = true;
            btnUpdate.Visible = false;
            txtName.Select();
            
        }

        #region theme color change

        FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        public void colorchangestaff()
        {
            if (frmmain.panelleft.BackColor == Color.FromArgb(253, 73, 131))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 120, 215))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(27, 182, 211))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(123, 31, 162))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(84, 110, 122))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 200, 83))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(217, 115, 65))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(217, 115, 65);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 115, 65);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(196, 30, 58))
            {
                dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
            }
        }

        public void colordaynight()
        {
            if (frmmain.panelTitle.BackColor == Color.FromArgb(41, 47, 57))
            {
                this.BackColor = Color.FromArgb(43, 55, 61);
                lblname.ForeColor = Color.White;
                lblpassword.ForeColor = Color.White;
                lblusername.ForeColor = Color.White;
                lblphonenumber.ForeColor = Color.White;
               
                txtName.FillColor = Color.FromArgb(45, 57, 68);
                txtName.ForeColor = Color.White;
                txtName.PlaceholderForeColor = Color.Gray;
                txtUsername.FillColor = Color.FromArgb(45, 57, 68);
                txtUsername.ForeColor = Color.White;
                txtUsername.PlaceholderForeColor = Color.Gray;
                txtPassword.FillColor = Color.FromArgb(45, 57, 68);
                txtPassword.ForeColor = Color.White;
                txtPassword.PlaceholderForeColor = Color.Gray;
                txtPhoneNumber.FillColor = Color.FromArgb(45, 57, 68);
                txtPhoneNumber.ForeColor = Color.White;
                txtPhoneNumber.PlaceholderForeColor = Color.Gray;
                txtGmail.FillColor = Color.FromArgb(45, 57, 68);
                txtGmail.ForeColor = Color.White;
                txtGmail.PlaceholderForeColor = Color.Gray;

                dgvStaff.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvStaff.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvStaff.DefaultCellStyle.ForeColor = Color.White;
                dgvStaff.GridColor = Color.FromArgb(41, 47, 57);
                dgvStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvStaff.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvStaff.DefaultCellStyle.SelectionForeColor = Color.White;
            }

        }

        #endregion

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter your real name");
                return false;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter your Username or nickname");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Your Password");
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter your phone number");
                return false;
            }
            if (string.IsNullOrEmpty(txtGmail.Text))
            {
                MessageBox.Show("Enter your gmail");
                return false;
            }
            return true;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                if (!CheckRequireFields()) return;
                MessageEntity res = new UserDao().SaveUser(1, new DAO.Entity.User()
                {
                    Name = txtName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Gmail = txtGmail.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Success");
                    Reset();
                    BindDgvData();
                    txtName.Select();
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

        private void BindDgvData()
        {
            try
            {
                dgvStaff.DataSource = null;
                ResUser res = new UserDao().GetAllUser();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvStaff.DataSource = res.LstUser;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region keydown
        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SendKeys.Send("{Tab}");
            //}
            if (e.KeyCode == Keys.Enter)
            {
                txtUsername.Focus();
            }
        }

        private void TxtUsername_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhoneNumber.Focus();
            }
        }

        private void TxtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGmail.Focus();
            }
        }

        private void TxtGmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.Focus();
            }
        }

        #endregion


        private void FrmStaff_Load(object sender, EventArgs e)
        {
            txtName.Select();
            BindDgvData();
            txtPassword.UseSystemPasswordChar = true;
            hidepassword.Visible = false;
        }

        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region  formMove

        //bool moving;
        //Point offset;
        //Point original;

        //void panel1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    moving = true;
        //    guna2Panel1.Capture = true;
        //    offset = MousePosition;
        //    original = this.Location;
        //}

        //void panel1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!moving)
        //        return;

        //    int x = original.X + MousePosition.X - offset.X;
        //    int y = original.Y + MousePosition.Y - offset.Y;

        //    this.Location = new Point(x, y);
        //}

        //void panel1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    moving = false;
        //    guna2Panel1.Capture = false;
        //}

        #endregion

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckRequireFields()) return;
                MessageEntity res = new UserDao().UpdateUser(1, new DAO.Entity.User()
                {
                    Id = id,
                    Name = txtName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Gmail = txtGmail.Text,
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

        private void DgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvStaff.SelectedRows[0];
            id = Convert.ToInt32(dgvRow.Cells["ColId"].Value);
            txtName.Text = dgvRow.Cells["ColName"].Value.ToString();
            txtUsername.Text = dgvRow.Cells["ColUsername"].Value.ToString();
            txtPassword.Text = Cryptography.Decrypt(dgvRow.Cells["ColPassword"].Value.ToString());
            txtPhoneNumber.Text = dgvRow.Cells["ColPhoneNumber"].Value.ToString();
            txtGmail.Text = dgvRow.Cells["ColGmail"].Value.ToString();
            btnRegister.Visible = false;
            btnUpdate.Visible = true;
        }

        private void DgvStaff_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStaff.Rows[e.RowIndex].Cells["ColDel"].ColumnIndex == e.ColumnIndex)
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        MessageEntity res1 = new UserDao().DeleteUser(Convert.ToInt32(dgvStaff.Rows[e.RowIndex].Cells["ColId"].Value));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e) //lowercase
        {
            e.KeyChar = char.ToLower(e.KeyChar);
        }


        private void Showpassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            hidepassword.Visible = true;
            showpassword.Visible = false;
        }

        private void Hidepassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            hidepassword.Visible = false;
            showpassword.Visible = true;
        }


       
    }
}
