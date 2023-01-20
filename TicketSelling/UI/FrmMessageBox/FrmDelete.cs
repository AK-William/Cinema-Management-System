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
        public FrmDelete()
        {
            InitializeComponent();
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void show()
        {

        }
    }
}
