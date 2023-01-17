using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmMain : Form
    {
        private int borderSize = 2;
        private Size formSize;

        public FrmMain()
        {
            InitializeComponent();
            CollapseMenu();
            HideSubMenu();
            txtLoginNameForMain.Text = FrmLogin.user;
            this.Padding = new Padding(borderSize);//Border size
            //this.BackColor = Color.FromArgb(51, 153, 255);//Border color
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e) // to move form with mouse
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CollapseMenu() //3 bars with responsive open and close
        {
            if (this.panelleft.Width > 200) //Collapse menu
            {
                panelleft.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                foreach (Button menuButton in panelConfiguration.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
                foreach (Button menuButton in panelEntry.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelleft.Width = 330;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                foreach (Button menuButton in panelConfiguration.Controls.OfType<Button>())
                {

                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    btnMovie.Padding = new Padding(30, 0, 0, 0);
                    btnSeat.Padding = new Padding(30, 0, 0, 0);
                }
                foreach (Button menuButton in panelEntry.Controls.OfType<Button>())
                {

                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    btnAdmin.Padding = new Padding(30, 0, 0, 0);
                    btnUser.Padding = new Padding(30, 0, 0, 0);
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
                                         ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            panelBody.Controls.Add(frmdashboard);
            frmdashboard.Dock = DockStyle.Fill;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Size = formSize;
        }


        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void ShowSubMenu(Panel pnl) // Button drop down open
        {
            //pnl.Height = pnl.Controls.OfType<Button>().Count() * 78;
            pnl.Height = 3 * btnDashboard.Height;
        }

        private void HideSubMenu() // Button drop down close
        {
            foreach (var pnl in panelMenu.Controls.OfType<Panel>())
            {
                pnl.Height = btnDashboard.Height;
            }
        }

        private void MenuClick(object sender, EventArgs e) //UserControl for Form show
        {
            UserControl frm = new UserControl();
            IconButton btn = (sender as IconButton);
            panelBody.Controls.Clear();
            switch (btn.Tag)
            {
                case "Seat":
                    frm = new FrmSeat();
                    lblTitleChildForm.Text = btnSeat.Tag.ToString();
                    iconCurrentChildForm.IconChar = btnSeat.IconChar;
                    break;
                case "Movie":
                    frm = new FrmMovie();
                    lblTitleChildForm.Text = btnMovie.Tag.ToString();
                    iconCurrentChildForm.IconChar = btnMovie.IconChar;
                    break;
                case "Users":
                    frm = new FrmUser();
                    lblTitleChildForm.Text = btnUser.Tag.ToString();
                    iconCurrentChildForm.IconChar = btnUser.IconChar;
                    break;
                case "Admin":
                    frm = new FrmAdmin();
                    lblTitleChildForm.Text = btnAdmin.Tag.ToString();
                    iconCurrentChildForm.IconChar = btnAdmin.IconChar;
                    break;
                case "Dashboard":
                    lblTitleChildForm.Text = btnDashboard.Tag.ToString();
                    iconCurrentChildForm.IconChar = btnDashboard.IconChar;
                    break;
                case "Setting":
                    frm = new FrmSetting();
                    lblTitleChildForm.Text = btnSetting.Tag.ToString();
                    iconCurrentChildForm.IconChar = btnSetting.IconChar;
                    break;
                case "Ticket":
                    frm = new FrmTicketSell();
                    lblTitleChildForm.Text = btnTicket.Tag.ToString();
                    iconCurrentChildForm.IconChar = btnTicket.IconChar;
                    break;
            }
            panelBody.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            MenuClick(sender, e);
            btnUser.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //staff button white fix
            ActivateButton(sender); //menu highlight active button
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            MenuClick(sender, e);
            ActivateButton(sender); //menu highlight active button
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Admin button white fix
        }

        UserControl frmdashboard = new FrmDashboard(); //declare outside to use in form load
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            MenuClick(sender, e);
            HideSubMenu();
            ActivateButton(sender); //menu highlight active button
            panelBody.Controls.Clear();
            panelBody.Controls.Add(frmdashboard);
            frmdashboard.Dock = DockStyle.Fill;
            frmdashboard.BackColor = panelTitle.BackColor;
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
            if (panelConfiguration.Height == btnConfiguration.Height)
            {
                ShowSubMenu(panelConfiguration);
                panelEntry.Height = btnEntry.Height;
            }

            else
            {
                HideSubMenu();
            }
        }

        private void BtnEntry_Click(object sender, EventArgs e)
        {
            if (panelEntry.Height == btnEntry.Height)
            {
                ShowSubMenu(panelEntry);
                panelConfiguration.Height = btnConfiguration.Height;
            }
            else
            {
                HideSubMenu();
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender); //menu highlight active button
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender); //menu highlight active button
            MenuClick(sender, e);
        }

        public void BtnSeat_Click(object sender, EventArgs e)
        {
            MenuClick(sender, e);
            ActivateButton(sender); //menu highlight active button
            //panelBody.Controls.Clear();
            //UserControl frmseat = new FrmSeat();
            //panelBody.Controls.Add(frmseat);
            //frmseat.Dock = DockStyle.Fill;
        }

        private void BtnMovie_Click(object sender, EventArgs e)
        {
            //panelBody.Controls.Clear();
            //UserControl frmMovie = new FrmMovie();
            //panelBody.Controls.Add(frmMovie);
            //frmMovie.Dock = DockStyle.Fill;
            MenuClick(sender, e);
            ActivateButton(sender); //menu highlight active button
        }

        #region tooltip

        private void BtnHome_MouseHover(object sender, EventArgs e)
        {
            toolTipHome.Show("Home", btnDashboard);
        }

        private void BtnConfiguration_MouseHover(object sender, EventArgs e)
        {
            toolTipConfiguration.Show("Configuration", btnConfiguration);
        }

        private void BtnSeat_MouseHover(object sender, EventArgs e)
        {
            toolTipSeat.Show("Seat", btnSeat);
        }

        private void BtnAdmin_MouseHover(object sender, EventArgs e)
        {
            toolTipAdmin.Show("Admin Registration", btnAdmin);
        }

        private void BtnEntry_MouseHover(object sender, EventArgs e)
        {
            toolTipEntry.Show("Entry Form", btnEntry);
        }

        private void Btnlogout_MouseHover(object sender, EventArgs e)
        {
            toolTipLogout.Show("Logout", btnlogout);
        }

        private void BtnMenu_MouseHover(object sender, EventArgs e)
        {
            toolTipMenu.Show("Menu", btnMenu);
        }

        private void BtnMovie_MouseHover(object sender, EventArgs e)
        {
            toolTipMovie.Show("Movie", btnMovie);
        }

        private void BtnReport_MouseHover(object sender, EventArgs e)
        {
            toolTipReport.Show("Report", btnReport);
        }

        private void BtnUser_MouseHover(object sender, EventArgs e)
        {
            toolTipStaffs.Show("Users", btnUser);
        }

        private void BtnTicket_MouseHover(object sender, EventArgs e)
        {
            toolTipTicket.Show("Ticket", btnTicket);
        }

        #endregion

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            if (panelAccountShow.Visible == false)
            {
                panelAccountShow.Visible = true;
            }
            else
            {
                panelAccountShow.Visible = false;
            }
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            FrmLogin flm = new FrmLogin();
            flm.Show();
            this.Close();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            MenuClick(sender, e);
            DisableButton();
        }

        #region menu highlight active button

        public IconButton currentBtn;

        public void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(41, 47, 57);
            }
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {
                if (panelleft.BackColor == Color.FromArgb(253, 73, 131))
                {
                    currentBtn.BackColor = Color.FromArgb(253, 73, 131);
                }
                else if (panelleft.BackColor == Color.FromArgb(0, 120, 215))
                {
                    currentBtn.BackColor = Color.FromArgb(0, 120, 215);
                }
                else if (panelleft.BackColor == Color.FromArgb(27, 182, 211))
                {
                    currentBtn.BackColor = Color.FromArgb(27, 182, 211);
                }
                else if (panelleft.BackColor == Color.FromArgb(123, 31, 162))
                {
                    currentBtn.BackColor = Color.FromArgb(123, 31, 162);
                }
                else if (panelleft.BackColor == Color.FromArgb(84, 110, 122))
                {
                    currentBtn.BackColor = Color.FromArgb(84, 110, 122);
                }
                else if (panelleft.BackColor == Color.FromArgb(0, 200, 83))
                {
                    currentBtn.BackColor = Color.FromArgb(0, 200, 83);
                }
                else if (panelleft.BackColor == Color.FromArgb(217, 115, 65))
                {
                    currentBtn.BackColor = Color.FromArgb(217, 115, 65); 
                }
                else if (panelleft.BackColor == Color.FromArgb(196, 30, 58))
                {
                    currentBtn.BackColor = Color.FromArgb(196, 30, 58);
                }

            }
        }


        #endregion

       
    }
}








