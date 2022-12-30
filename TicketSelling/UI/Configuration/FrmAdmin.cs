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
using System.IO;
using System.Windows.Media.Imaging;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmAdmin : UserControl
    {
        string imgUrl;
        byte[] codeImage;
        string strString = null;
        string AdminPhotoName = string.Empty;
        Boolean AnyChanges = false;

        public FrmAdmin()
        {
            InitializeComponent();
            dgvAdmin.AutoGenerateColumns = false;
            colorchangeadmin();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            txtAdminName.Select();
            BindDgvAdmin();
            txtAdminPassword.UseSystemPasswordChar = true;
            hidepassword.Visible = false;
        }

        private void Reset()
        {
            pictureBoxAdminPhoto.Image = null;
            txtAdminName.Text = "";
            txtAdminUsername.Text = "";
            txtAdminPassword.Text = "";
            txtAdminGmail.Text = "";
            txtAdminPhoneNumber.Text = "";
            txtAdminNRC.Text = "";
            txtAdminAddress.Text = "";
            txtAdminCity.Text = "";
            txtAdminPostcode.Text = "";
            cbuserrole.Text = "";
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            txtAdminName.Select();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }


        #region theme color change

        FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        public void colorchangeadmin()
        {
            if (frmmain.panelleft.BackColor == Color.FromArgb(253, 73, 131))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 120, 215))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(27, 182, 211))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(123, 31, 162))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(84, 110, 122))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 200, 83))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(255, 214, 0))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 214, 0);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 214, 0);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(196, 30, 58))
            {
                dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvAdmin.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
            }
        }

        #endregion


        #region KeyDown

        private void TxtAdminName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminUsername.Focus();
            }
        }

        private void TxtAdminUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminPassword.Focus();
            }
        }

        private void TxtAdminPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminGmail.Focus();
            }
        }

        private void TxtAdminGmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminPhoneNumber.Focus();
            }
        }

        private void TxtAdminPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminNRC.Focus();
            }
        }

        private void TxtAdminNRC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminAddress.Focus();
            }
        }

        private void TxtAdminAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminCity.Focus();
            }
        }

        private void TxtAdminCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAdminPostcode.Focus();
            }
        }

        private void TxtAdminPostcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxAdminPhoto.Focus();
            }
        }

        #endregion


        private void PictureBoxAdminPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.gif;) | *.jpg;*.jpeg;*.gif;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgUrl = ofd.FileName;
                FileStream fStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                codeImage = new byte[fStream.Length];
                fStream.Read(codeImage, 0, (Int32)fStream.Length);
                fStream.Dispose();
                pictureBoxAdminPhoto.Text = ofd.FileName;
                pictureBoxAdminPhoto.Image = new Bitmap(ofd.FileName);
                pictureBoxAdminPhoto.ImageLocation = ofd.FileName;
                pictureBoxAdminPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                AnyChanges = true;
            }
        }

        private bool CheckRequireFields()
        {
            
            if (string.IsNullOrEmpty(txtAdminName.Text))
            {
                MessageBox.Show("Enter your Real Name");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminUsername.Text))
            {
                MessageBox.Show("Enter username");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminPassword.Text))
            {
                MessageBox.Show("Enter your Password");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminGmail.Text))
            {
                MessageBox.Show("Enter your Gmail");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminPhoneNumber.Text))
            {
                MessageBox.Show("Enter your Phone Number");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminNRC.Text))
            {
                MessageBox.Show("Enter your National ID card");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminAddress.Text))
            {
                MessageBox.Show("Enter your Address");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminCity.Text))
            {
                MessageBox.Show("Enter your City");
                return false;
            }
            if (string.IsNullOrEmpty(txtAdminPostcode.Text))
            {
                MessageBox.Show("Enter your Postcode");
                return false;
            }
            if (string.IsNullOrEmpty(pictureBoxAdminPhoto.Text))
            {
                MessageBox.Show("Enter your photo");
                return false;
            }
            if (string.IsNullOrEmpty(pictureBoxAdminPhoto.Text))
            {
                MessageBox.Show("Enter your ID Photo");
                return false;
            }
            if (string.IsNullOrEmpty(cbuserrole.Text))
            {
                MessageBox.Show("Enter your role");
                return false;
            }
            return true;
        }

        private void SaveData()
        {
            try
            {
                if (!CheckRequireFields()) return;
                MessageEntity res = new AdminDao().SaveAdmin(1, new DAO.Entity.Admin()
                {
                    Name = txtAdminName.Text,
                    Username = txtAdminUsername.Text,
                    Role = cbuserrole.Text,
                    Password = txtAdminPassword.Text,
                    Gmail = txtAdminGmail.Text,
                    PhoneNumber = txtAdminPhoneNumber.Text,
                    NRC = txtAdminNRC.Text,
                    Address = txtAdminAddress.Text,
                    City = txtAdminCity.Text,
                    Postcode = txtAdminPostcode.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    SaveImageFilePath(res.AdminPhotoName);
                    UpdateAdminPhoto(res.AdminId);
                     Reset();
                     BindDgvAdmin();
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

        private void UpdateAdminPhoto(int AdminId)
        {
            try
            {
                MessageEntity res = new AdminDao().UpdateAdminPhoto(new DAO.Entity.Admin()
                {
                    Id = AdminId,
                    Photo = strString
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Success");
                    Reset();
                    BindDgvAdmin();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SaveImageFilePath(string AdminPhotoName)
        {
            if (imgUrl.Length > 0)
            {
                string extension = System.IO.Path.GetExtension(imgUrl);
                string serverPhotoPath = Path.Combine(@"C:\Shared\Images\Admin\");
                strString = serverPhotoPath + AdminPhotoName + extension;
                Bitmap imgOutforsaveondisk = CommonFormat.ConvertTo16bpp(CommonFormat.getResizedImage(codeImage, 800, 600));
                imgOutforsaveondisk.Save(strString);
            }

        }

        private void EditImageFilePath(string AdminPhotoName)
        {
            string strString = null;
            if (imgUrl.Length > 0)
            {
                string serverPhotoPath = Path.Combine(@"C:\Shared\Images\Admin\");

                string extension = System.IO.Path.GetExtension(imgUrl);
                string name = AdminPhotoName + extension;

                strString = serverPhotoPath + name;

                Bitmap orgBitmap = new Bitmap(imgUrl);
                orgBitmap.Save(strString);
                orgBitmap.Dispose();

            }
            else
            {
                strString = "";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void BindDgvAdmin()
        {
            try
            {
                dgvAdmin.DataSource = null;
                ResAdmin res = new AdminDao().GetAllAdmin();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvAdmin.DataSource = res.LstAdmin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowImage(string fileName) //show image in datagridview
        {
            Bitmap orgBitmapImage = new Bitmap(fileName);
            pictureBoxAdminPhoto.Image = orgBitmapImage;
        }

        int id = -1;

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnyChanges)
                {
                    EditImageFilePath(AdminPhotoName);
                }
                if (!CheckRequireFields()) return;
                MessageEntity res = new AdminDao().UpdateAdmin(1, new DAO.Entity.Admin()
                {
                    Id = id,
                    Name = txtAdminName.Text,
                    Photo = strString,
                    Role = cbuserrole.Text,
                    Username = txtAdminUsername.Text,
                    Password = txtAdminPassword.Text,
                    Gmail = txtAdminGmail.Text,
                    PhoneNumber = txtAdminPhoneNumber.Text,
                    NRC = txtAdminNRC.Text,
                    Address = txtAdminAddress.Text,
                    City = txtAdminCity.Text,
                    Postcode = txtAdminPostcode.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Update Success");
                    Reset();
                    BindDgvAdmin();
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

        private void DgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAdmin.Rows[e.RowIndex].Cells["ColDel"].ColumnIndex == e.ColumnIndex)
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        MessageEntity res1 = new AdminDao().DeleteAdmin(Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells["ColId"].Value));
                        if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show("Delete Success");
                            Reset();
                            BindDgvAdmin();
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

        private void DgvAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRowST = dgvAdmin.SelectedRows[0];
            id = Convert.ToInt32(dgvRowST.Cells["ColId"].Value);
            txtAdminName.Text = dgvRowST.Cells["ColAdminName"].Value.ToString();
            cbuserrole.Text = dgvRowST.Cells["Coluserrole"].Value.ToString();
            txtAdminUsername.Text = dgvRowST.Cells["ColAdminUsername"].Value.ToString();
            txtAdminPassword.Text = Cryptography.Decrypt(dgvRowST.Cells["ColAdminPassword"].Value.ToString());
            txtAdminGmail.Text = dgvRowST.Cells["ColAdminGmail"].Value.ToString();
            txtAdminPhoneNumber.Text = dgvRowST.Cells["ColAdminPhoneNumber"].Value.ToString();
            txtAdminNRC.Text = dgvRowST.Cells["ColAdminNRC"].Value.ToString();
            txtAdminAddress.Text = dgvRowST.Cells["ColAdminAddress"].Value.ToString();
            txtAdminCity.Text = dgvRowST.Cells["ColAdminCity"].Value.ToString();
            txtAdminPostcode.Text = dgvRowST.Cells["ColAdminPostcode"].Value.ToString();
            ShowImage(dgvRowST.Cells["ColAdminPhotoString"].Value.ToString()); // show iamge in data grid view
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            strString = dgvRowST.Cells["ColAdminPhotoString"].Value.ToString();
            AdminPhotoName = "A-" + id;
            FileStream fStream = new FileStream(strString, FileMode.Open, FileAccess.Read);
            codeImage = new byte[fStream.Length];

            fStream.Read(codeImage, 0, (Int32)fStream.Length);

            fStream.Dispose();

            pictureBoxAdminPhoto.Text = strString;
        }

        private void TxtAdminPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtAdminUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void Showpassword_Click(object sender, EventArgs e)
        {
            txtAdminPassword.UseSystemPasswordChar = false;
            hidepassword.Visible = true;
            showpassword.Visible = false;

        }

        private void Hidepassword_Click(object sender, EventArgs e)
        {
            txtAdminPassword.UseSystemPasswordChar = true;
            hidepassword.Visible = false;
            showpassword.Visible = true;
        }
    }
}
