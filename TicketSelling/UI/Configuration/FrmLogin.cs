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
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please enter your username";
                fmW.ShowDialog();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                FrmMessageBox.FrmWarning fmW = new FrmMessageBox.FrmWarning();
                fmW.lblWarning.Text = "Please enter your password";
                fmW.ShowDialog();
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
            //    MessageEntity res = new UserDao().Login(new DAO.Entity.User()
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
                    FrmMessageBox.FrmNormal fmN = new FrmMessageBox.FrmNormal();
                    fmN.lblNormal.Text =res.RespDesp;
                    fmN.ShowDialog();
                    FrmMain frm = new FrmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    FrmMessageBox.FrmError fmE = new FrmMessageBox.FrmError();
                    fmE.lblError.Text = res.RespDesp;
                    fmE.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                FrmMessageBox.FrmExMessage frmExMessage = new FrmMessageBox.FrmExMessage();
                frmExMessage.lblExMessage.Text = ex.Message;
                frmExMessage.ShowDialog();
            }



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
