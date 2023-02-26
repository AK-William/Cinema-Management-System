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
    public partial class FrmDashboard1 : UserControl
    {
        public FrmDashboard1()
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

            colorchange();
        }

       
        public void BindDgvMovieDB1()
        {
            try
            {
                dgvMovieDB1.DataSource = null;
                ResMovie res = new DashboardDao().GetAllMovie();
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
                ResMovie res = new DashboardDao().GetAllMovie();
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
                ResMovie res = new DashboardDao().GetAllMovie();
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
                ResMovie res = new DashboardDao().GetAllMovie();
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
                ResMovie res = new DashboardDao().GetAllMovie();
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
                ResMovie res = new DashboardDao().GetAllMovie();
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
                ResMovie res = new DashboardDao().GetAllMovie();
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
                ResMovie res = new DashboardDao().GetAllMovie();
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

       public void colorchange()
        {
            if (this.BackColor == Color.FromArgb(41, 47, 57))
            {
                lbltitle.ForeColor = Color.White;

                dgvMovieDB1.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB1.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB1.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDB1.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDB1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDB1.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvMovieDB2.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB2.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB2.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDB2.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDB2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDB2.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvMovieDB3.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB3.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB3.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDB3.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDB3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB3.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDB3.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvMovieDB4.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB4.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB4.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDB4.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDB4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDB4.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDB4.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvMovieDBN1.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN1.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN1.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDBN1.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDBN1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDBN1.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvMovieDBN2.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN2.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN2.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDBN2.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDBN2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDBN2.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvMovieDBN3.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN3.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN3.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDBN3.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDBN3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN3.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDBN3.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvMovieDBN4.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN4.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN4.DefaultCellStyle.ForeColor = Color.White;
                dgvMovieDBN4.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovieDBN4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovieDBN4.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovieDBN4.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }
    }
}
