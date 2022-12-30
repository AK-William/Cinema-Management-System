using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmDashboard : UserControl
    {
        public FrmDashboard()
        {
            InitializeComponent();
            dgvMovieDB2.AutoGenerateColumns = false;
            dgvMovieDB1.AutoGenerateColumns = false;
            dgvMovieDB3.AutoGenerateColumns = false;
            dgvMovieDB4.AutoGenerateColumns = false;

            dgvMovieDBN1.AutoGenerateColumns = false;
            dgvMovieDBN2.AutoGenerateColumns = false;
            dgvMovieDBN3.AutoGenerateColumns = false;
            dgvMovieDBN4.AutoGenerateColumns = false;
            
        }

       
        public void BindDgvMovieDB1()
        {
            try
            {
                dgvMovieDB1.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB1();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDB1.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDgvMovieDB2()
        {
            try
            {
                dgvMovieDB2.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB2();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDB2.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDgvMovieDB3()
        {
            try
            {
                dgvMovieDB3.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB3();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDB3.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDgvMovieDB4()
        {
            try
            {
                dgvMovieDB4.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB4();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDB4.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDgvMovieDBN1()
        {
            try
            {
                dgvMovieDBN1.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB1();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDBN1.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDgvMovieDBN2()
        {
            try
            {
                dgvMovieDBN2.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB2();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDBN2.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDgvMovieDBN3()
        {
            try
            {
                dgvMovieDBN3.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB3();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDBN3.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDgvMovieDBN4()
        {
            try
            {
                dgvMovieDBN4.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovieDB4();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovieDBN4.DataSource = res.LstMovie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            BindDgvMovieDB1();
            BindDgvMovieDB2();
            BindDgvMovieDB3();
            BindDgvMovieDB4();
            BindDgvMovieDBN1();
            BindDgvMovieDBN2();
            BindDgvMovieDBN3();
            BindDgvMovieDBN4();
        }
    }
}
