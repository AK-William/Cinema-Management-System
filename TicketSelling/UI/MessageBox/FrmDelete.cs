using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling.UI.FrmMessageBox
{
    public partial class FrmDelete : Form
    {
        #region Shadow Decoration 

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        #endregion

        string strMessage = "";
        string strTitle = "";
        public bool isYesOrNo;
        bool SystemErrorORUserError;

        public FrmDelete(string message, string title, bool systemErrorORUserError = false)
        {
            InitializeComponent();
            strMessage = message;
            SystemErrorORUserError = systemErrorORUserError;
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            isYesOrNo = false;
            this.Close();
        }
        public void show()
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            isYesOrNo = true;
            this.Close();
        }

        private void FrmDelete_Load(object sender, EventArgs e)
        {
            label2.Text = strMessage;
        }
    }
}
