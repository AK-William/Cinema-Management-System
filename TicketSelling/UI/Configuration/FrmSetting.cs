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
        }

        FrmSeat frmseat = new FrmSeat();
       // FrmLogin frmlogin = new FrmLogin();

        public void CbChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];
           
            switch (cbChangeColor.SelectedIndex)
            {
                case 0:
                    frmmain.panelleft.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnStaff.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnMovie.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnSeat.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnHome.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnTicket.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnReport.BackColor = Color.FromArgb(0, 120, 215);
                    frmmain.btnAccount.IconColor = Color.FromArgb(0, 120, 215);
                    frmmain.accountimage.IconColor = Color.FromArgb(0, 120, 215);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(0, 120, 215);
                    frmseat.dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                    frmseat.dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                    break;
                case 1:
                    frmmain.panelleft.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnStaff.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnMovie.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnSeat.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnHome.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnTicket.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnReport.BackColor = Color.FromArgb(253, 73, 131);
                    frmmain.btnAccount.IconColor = Color.FromArgb(253, 73, 131);
                    frmmain.accountimage.IconColor = Color.FromArgb(253, 73, 131);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(253, 73, 131);
                    frmseat.dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                    frmseat.dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                    break;
                case 2:
                    frmmain.panelleft.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.panelMenuBar.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.paneltitlebar.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnAdmin.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnStaff.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnMovie.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnSeat.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnHome.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnTicket.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnReport.BackColor = Color.FromArgb(27, 182, 211);
                    frmmain.btnAccount.IconColor = Color.FromArgb(27, 182, 211);
                    frmmain.accountimage.IconColor = Color.FromArgb(27, 182, 211);
                    frmmain.panelAccountShow.BorderColor = Color.FromArgb(27, 182, 211);
                    frmseat.dgvSeat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                    frmseat.dgvSeatType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
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
    }
}
