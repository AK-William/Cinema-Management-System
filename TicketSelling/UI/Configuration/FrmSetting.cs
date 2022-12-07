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

       

        public void  ColorTheme(string color)
        {
            this.BackColor = Color.FromName(color);
          FrmMain.ActiveForm.BackColor = Color.FromName(color);
        }

        private void CbChangeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorTheme(cbChangeColor.Text);
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

