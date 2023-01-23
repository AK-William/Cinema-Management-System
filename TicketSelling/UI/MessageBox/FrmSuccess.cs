using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling.UI.FrmMessageBox
{
    public partial class FrmSuccess : Form
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

        public FrmSuccess()
        {
            InitializeComponent();
        }


        private void BtnSuccessExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSuccessOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FrmSuccess_Load(object sender, EventArgs e)
        {
           
        }
    }
}
