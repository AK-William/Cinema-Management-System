using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.UI.Configuration;


namespace TicketSelling.UI.Configuration
{
    public partial class FrmSetting : UserControl
    {

        public FrmSetting()
        {
            InitializeComponent();
            dayw.Visible = false;
            nightw.Visible = false;
            colorchangesetting();
           
        }

        public void colorchangesetting()
        {
            if (frmmain.panelTitle.BackColor == Color.FromArgb(41, 47, 57))
            {
                this.BackColor = Color.FromArgb(41, 47, 57);
                daynight.Checked = true;
            }
            else 
            {
                this.BackColor = Color.White;
            }
           
        }

        FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        public void CbChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            switch (cbChangeColor.SelectedIndex)
            {
                case 0:
                    frmmain.panelleft.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnUser.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnMovie.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnSeat.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnTicket.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnReport.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnAccount.IconColor = Color.FromArgb(0, 120, 215);
                    frmmain.accountimage.IconColor = Color.FromArgb(0, 120, 215);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(0, 120, 215);
                    break;

                case 1:
                    frmmain.panelleft.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnUser.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnMovie.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnSeat.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnTicket.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnReport.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnAccount.IconColor = Color.FromArgb(253, 73, 131);
                    frmmain.accountimage.IconColor = Color.FromArgb(253, 73, 131);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(253, 73, 131);
                    break;

                case 2:
                    frmmain.panelleft.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnUser.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnMovie.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnSeat.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnTicket.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnReport.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnAccount.IconColor = Color.FromArgb(27, 182, 211);
                    frmmain.accountimage.IconColor = Color.FromArgb(27, 182, 211);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(27, 182, 211);
                    break;
                    
                case 3:
                    frmmain.panelleft.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnUser.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnMovie.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnSeat.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnTicket.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnReport.BackColor = Color.FromArgb(123, 31, 162);
                    frmmain.btnAccount.IconColor = Color.FromArgb(123, 31, 162);
                    frmmain.accountimage.IconColor = Color.FromArgb(123, 31, 162);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(123, 31, 162);
                    break;
                    
                case 4:
                    frmmain.panelleft.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnUser.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnMovie.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnSeat.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnTicket.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnReport.BackColor = Color.FromArgb(84, 110, 122);
                    frmmain.btnAccount.IconColor = Color.FromArgb(84, 110, 122);
                    frmmain.accountimage.IconColor = Color.FromArgb(84, 110, 122);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(84, 110, 122);
                    break;

                case 5:
                    frmmain.panelleft.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnUser.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnMovie.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnSeat.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnTicket.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnReport.BackColor = Color.FromArgb(0, 200, 83);
                    frmmain.btnAccount.IconColor = Color.FromArgb(0, 200, 83);
                    frmmain.accountimage.IconColor = Color.FromArgb(0, 200, 83);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(0, 200, 83);
                    break;

                case 6:
                    frmmain.panelleft.BackColor = Color.FromArgb(217,115,65);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnUser.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnMovie.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnSeat.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnTicket.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnReport.BackColor = Color.FromArgb(217, 115, 65);
                    frmmain.btnAccount.IconColor = Color.FromArgb(217, 115, 65);
                    frmmain.accountimage.IconColor = Color.FromArgb(217, 115, 65);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(217, 115, 65);
                    break;

                case 7:
                    frmmain.panelleft.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnUser.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnMovie.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnSeat.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnDashboard.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnTicket.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnReport.BackColor = Color.FromArgb(196, 30, 58);
                    frmmain.btnAccount.IconColor = Color.FromArgb(196, 30, 58);
                    frmmain.accountimage.IconColor = Color.FromArgb(196, 30, 58);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(196, 30, 58);
                    break;
            }
        }


        public void CbChangeLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbChangeLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("my-MM");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }


        private void Daynight_CheckedChanged(object sender, EventArgs e)
        {
            if (daynight.Checked == true)
            {
                this.BackColor = Color.FromArgb(41, 47, 57);
                dayw.Visible = true;
                nightw.Visible = true;
                dayb.Visible = false;
                nightb.Visible = false;
                lblchangecolor.ForeColor = Color.White;
                lblchangelanguage.ForeColor = Color.White;
                lblDayNight.ForeColor = Color.White;
                frmmain.panelTitle.BackColor = Color.FromArgb(41, 47, 57);
                frmmain.label1.ForeColor = Color.White;
                frmmain.txtLoginNameForMain.ForeColor = Color.White;
                frmmain.btnAccount.FlatAppearance.MouseDownBackColor= Color.FromArgb(68, 87, 96);
                frmmain.btnSetting.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 87, 96);
               
            }
            else
            {
                this.BackColor = Color.White;
                dayw.Visible = false;
                nightw.Visible = false;
                dayb.Visible = true;
                nightb.Visible = true;
                lblchangecolor.ForeColor = Color.Black;
                lblchangelanguage.ForeColor = Color.Black;
                lblDayNight.ForeColor = Color.Black;
                frmmain.panelTitle.BackColor = Color.White;
                frmmain.label1.ForeColor = Color.Black;
                frmmain.txtLoginNameForMain.ForeColor = Color.Black;
                frmmain.btnAccount.FlatAppearance.MouseDownBackColor = Color.LightGray;
                frmmain.btnSetting.FlatAppearance.MouseDownBackColor = Color.LightGray;
            }
        }

       
    }
}
