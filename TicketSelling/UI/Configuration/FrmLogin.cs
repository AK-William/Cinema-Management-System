using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.Select();
        }

        public static string user;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter your Username");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Password");
                return false;
            }
            return true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!CheckRequireFields()) return;
            //    MessageEntity res = new StaffDao().Login(new DAO.Entity.Staff()
            //    {
            //        Username = txtUsername.Text,
            //        Password = txtPassword.Text
            //    });
            //    if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
            //    {
            //        user = txtUsername.Text;
            //        MessageBox.Show(res.RespDesp);
            //        FrmMain frm = new FrmMain();
            //        frm.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show(res.RespDesp);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}


            try
            {
                if (!CheckRequireFields()) return;
                MessageEntity res = new AdminDao().Login(new DAO.Entity.Admin()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    user = txtUsername.Text;
                    MessageBox.Show(res.RespDesp);
                    FrmMain frm = new FrmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(res.RespDesp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ENSCQA99;Initial Catalog=TicketSellingSystem;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Type from TblAdmin Where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'   ", con);
            //DataTable dt = new System.Data.DataTable();
            //sda.Fill(dt);

            //if (dt.Rows.Count == 1)
            //{
            //    switch (dt.Rows[0]["Type"] as string)
            //    {
            //        case "Admin":
            //            {
            //                this.Hide();
            //                FrmMain ss = new FrmMain();
            //                ss.Show();
            //                break;
            //            }

            //        case "Staff":
            //            {
            //                this.Hide();
            //                FrmMain ss = new FrmMain();
            //                ss.Show();
            //                break;
            //            }

            //        default:
            //            {
            //                // ... handle unexpected roles here...
            //                break;
            //            }
            //    }
            //}

        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }

        private void ChkSP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSP.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
