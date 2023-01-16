using TicketSelling.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO.Entity;
using System.IO;
using System.Windows.Media.Imaging;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmMovie : UserControl
    {
        string imgUrl;
        byte[] codeImage;
        string strString = null;
        string MovieCoverName = string.Empty;
        Boolean AnyChanges = false;

        public FrmMovie()
        {
            InitializeComponent();
            dgvMovie.AutoGenerateColumns = false;
            dgvSD.AutoGenerateColumns = false;
            dgvST.AutoGenerateColumns = false;
            btnMovieUpdate.Visible = false;
            colorchangemovie();
            colordaynight();
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            BindDgvMovieSD();
            BindDgvMovie();
            txtName.Select();
            txtSDStartDate.Value = DateTime.Now;
            txtSDEndDate.Value = DateTime.Now;
            STDate.Value = DateTime.Now;
            STTime.Format = DateTimePickerFormat.Time;
            STTime.ShowUpDown = true;
        }


        #region theme color change

        FrmMain frmmain = (FrmMain)Application.OpenForms["FrmMain"];

        public void colorchangemovie()
        {
            if (frmmain.panelleft.BackColor == Color.FromArgb(253, 73, 131))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 73, 131);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(253, 73, 131);
                txtSDStartDate.FillColor = Color.FromArgb(253, 73, 131);
                txtSDEndDate.FillColor = Color.FromArgb(253, 73, 131);
                STDate.FillColor = Color.FromArgb(253, 73, 131);
                STTime.FillColor = Color.FromArgb(253, 73, 131);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 120, 215))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                txtSDStartDate.FillColor = Color.FromArgb(0, 120, 215);
                txtSDEndDate.FillColor = Color.FromArgb(0, 120, 215);
                STDate.FillColor = Color.FromArgb(0, 120, 215);
                STTime.FillColor = Color.FromArgb(0, 120, 215);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(27, 182, 211))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 182, 211);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 182, 211);
                txtSDStartDate.FillColor = Color.FromArgb(27, 182, 211);
                txtSDEndDate.FillColor = Color.FromArgb(27, 182, 211);
                STDate.FillColor = Color.FromArgb(27, 182, 211);
                STTime.FillColor = Color.FromArgb(27, 182, 211);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(123, 31, 162))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(123, 31, 162);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(123, 31, 162);
                txtSDStartDate.FillColor = Color.FromArgb(123, 31, 162);
                txtSDEndDate.FillColor = Color.FromArgb(123, 31, 162);
                STDate.FillColor = Color.FromArgb(123, 31, 162);
                STTime.FillColor = Color.FromArgb(123, 31, 162);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(84, 110, 122))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(84, 110, 122);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(84, 110, 122);
                txtSDStartDate.FillColor = Color.FromArgb(84, 110, 122);
                txtSDEndDate.FillColor = Color.FromArgb(84, 110, 122);
                STDate.FillColor = Color.FromArgb(84, 110, 122);
                STTime.FillColor = Color.FromArgb(84, 110, 122);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(0, 200, 83))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 200, 83);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 200, 83);
                txtSDStartDate.FillColor = Color.FromArgb(0, 200, 83);
                txtSDEndDate.FillColor = Color.FromArgb(0, 200, 83);
                STDate.FillColor = Color.FromArgb(0, 200, 83);
                STTime.FillColor = Color.FromArgb(0, 200, 83);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(255, 214, 0))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 214, 0);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 214, 0);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 214, 0);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 214, 0);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 214, 0);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 214, 0);
                txtSDStartDate.FillColor = Color.FromArgb(255, 214, 0);
                txtSDEndDate.FillColor = Color.FromArgb(255, 214, 0);
                STDate.FillColor = Color.FromArgb(255, 214, 0);
                STTime.FillColor = Color.FromArgb(255, 214, 0);
            }
            else if (frmmain.panelleft.BackColor == Color.FromArgb(196, 30, 58))
            {
                dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvMovie.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
                dgvSD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvSD.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
                dgvST.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(196, 30, 58);
                dgvST.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(196, 30, 58);
                txtSDStartDate.FillColor = Color.FromArgb(196, 30, 58);
                txtSDEndDate.FillColor = Color.FromArgb(196, 30, 58);
                STDate.FillColor = Color.FromArgb(196, 30, 58);
                STTime.FillColor = Color.FromArgb(196, 30, 58);
            }
        }

        public void colordaynight()
        {
            if (frmmain.panelTitle.BackColor == Color.FromArgb(41, 47, 57))
            {
                tabMovie.BackColor = Color.FromArgb(43, 55, 61);
                lblname.ForeColor = Color.White;
                lblcasts.ForeColor = Color.White;
                lblruntime.ForeColor = Color.White;
                lblmovietype.ForeColor = Color.White;
                lbldescription.ForeColor = Color.White;
                lbltrailerlink.ForeColor = Color.White;
                lblmoviecover.ForeColor = Color.White;
                txtName.FillColor = Color.FromArgb(45, 57, 68);
                txtName.ForeColor = Color.White;
                txtName.PlaceholderForeColor = Color.Gray;
                txtCasts.FillColor = Color.FromArgb(45, 57, 68);
                txtCasts.ForeColor = Color.White;
                txtCasts.PlaceholderForeColor = Color.Gray;
                txtRuntime.FillColor = Color.FromArgb(45, 57, 68);
                txtRuntime.ForeColor = Color.White;
                txtRuntime.PlaceholderForeColor = Color.Gray;
                txtMovieType.FillColor = Color.FromArgb(45, 57, 68);
                txtMovieType.ForeColor = Color.White;
                txtMovieType.PlaceholderForeColor = Color.Gray;
                txtDescription.FillColor = Color.FromArgb(45, 57, 68);
                txtDescription.ForeColor = Color.White;
                txtDescription.PlaceholderForeColor = Color.Gray;
                txtMovieLink.FillColor = Color.FromArgb(45, 57, 68);
                txtMovieLink.ForeColor = Color.White;
                txtMovieLink.PlaceholderForeColor = Color.Gray;
                pictureBox.FillColor = Color.FromArgb(68, 87, 96);
                dgvMovie.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvMovie.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovie.DefaultCellStyle.ForeColor = Color.White;
                dgvMovie.GridColor = Color.FromArgb(41, 47, 57);
                dgvMovie.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvMovie.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvMovie.DefaultCellStyle.SelectionForeColor = Color.White;

                tabScheduleDate.BackColor = Color.FromArgb(43, 55, 61);
                lblSDName.ForeColor = Color.White;
                lblSDstartdate.ForeColor = Color.White;
                lblSDenddate.ForeColor = Color.White;
                CbSDName.FillColor = Color.FromArgb(45, 57, 68);
                CbSDName.ForeColor = Color.White;
                txtSDStartDate.ForeColor = Color.White;
                txtSDEndDate.ForeColor = Color.White;
                dgvSD.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvSD.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvSD.DefaultCellStyle.ForeColor = Color.White;
                dgvSD.GridColor = Color.FromArgb(41, 47, 57);
                dgvSD.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvSD.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvSD.DefaultCellStyle.SelectionForeColor = Color.White;

                tabScheduleTime.BackColor = Color.FromArgb(43, 55, 61);
                lblSTname.ForeColor = Color.White;
                lblSTdate.ForeColor = Color.White;
                lblSTtime.ForeColor = Color.White;
                CbSTName.FillColor = Color.FromArgb(45, 57, 68);
                CbSTName.ForeColor = Color.White;
                STDate.ForeColor = Color.White;
                STTime.ForeColor = Color.White;
                dgvST.BackgroundColor = Color.FromArgb(68, 87, 96);
                dgvST.DefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvST.DefaultCellStyle.ForeColor = Color.White;
                dgvST.GridColor = Color.FromArgb(41, 47, 57);
                dgvST.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(68, 87, 96);
                dgvST.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 55, 61);
                dgvST.DefaultCellStyle.SelectionForeColor = Color.White;
            }

        }

        #endregion


        #region MOVIE


        #region MovieKeyDown

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCasts.Focus();
            }
        }

        private void TxtCasts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRuntime.Focus();
            }
        }

        private void TxtRuntime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMovieType.Focus();
            }
        }

        private void TxtMovieType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void TxtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMovieLink.Focus();
            }
        }

        private void TxtMovieLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMovieSearch.Focus();
            }
        }

        #endregion

        private void Reset()
        {
            txtName.Text = "";
            txtCasts.Text = "";
            txtDescription.Text = "";
            txtMovieLink.Text = "";
            txtMovieType.Text = "";
            txtRuntime.Text = "";
            pictureBox.Image = null;
            AnyChanges = false;
            btnMovieUpdate.Visible = false;
            btnMovieSave.Visible = true;
            txtName.Select();
        }

        private void BtnMovieSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.gif;) | *.jpg;*.jpeg;*.gif;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgUrl = ofd.FileName;
                FileStream fStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                codeImage = new byte[fStream.Length];
                fStream.Read(codeImage, 0, (Int32)fStream.Length);
                fStream.Dispose();
                pictureBox.Text = ofd.FileName;
                pictureBox.Image = new Bitmap(ofd.FileName);
                pictureBox.ImageLocation = ofd.FileName;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                AnyChanges = true;
            }
        }

        private void BtnMovieCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Movie Name");
                return false;
            }
            if (string.IsNullOrEmpty(txtCasts.Text))
            {
                MessageBox.Show("Enter Casts' Name");
                return false;
            }
            if (string.IsNullOrEmpty(txtRuntime.Text))
            {
                MessageBox.Show("Enter Movie's Runtime");
                return false;
            }
            if (string.IsNullOrEmpty(txtMovieType.Text))
            {
                MessageBox.Show("Enter Movie Type");
                return false;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Enter Preview Description");
                return false;
            }
            if (string.IsNullOrEmpty(txtMovieLink.Text))
            {
                MessageBox.Show("Enter Movie Trailer Link");
                return false;
            }
            if (string.IsNullOrEmpty(pictureBox.Text))
            {
                MessageBox.Show("Enter Movie Cover");
                return false;
            }

            return true;
        }

        private void SaveData()
        {
            try
            {
                if (!CheckRequireFields()) return;
                MessageEntity res = new MovieDao().SaveMovie(1, new DAO.Entity.Movie()
                {
                    Name = txtName.Text,
                    Casts = txtCasts.Text,
                    Runtime = txtRuntime.Text,
                    MovieType = txtMovieType.Text,
                    Description = txtDescription.Text,
                    TrailerLink = txtMovieLink.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    SaveImageFilePath(res.MovieCoverName);
                    UpdateMovieCover(res.MovieId);
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void UpdateMovieCover(int MovieId)
        {
            try
            {
                MessageEntity res = new MovieDao().UpdateMovieCover(new DAO.Entity.Movie()
                {
                    Id = MovieId,
                    MovieCover = strString

                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Success");
                    Reset();
                    BindDgvMovie();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SaveImageFilePath(string MovieCoverName)
        {
            if (imgUrl.Length > 0)
            {
                string extension = System.IO.Path.GetExtension(imgUrl);
                string serverPhotoPath = Path.Combine(@"C:\Shared\Images\");
                strString = serverPhotoPath + MovieCoverName + extension;
                Bitmap imgOutforsaveondisk = CommonFormat.ConvertTo16bpp(CommonFormat.getResizedImage(codeImage, 800, 600));
                imgOutforsaveondisk.Save(strString);
            }

        }

        private void EditImageFilePath(string MovieCoverName)
        {
            string strString = null;
            if (imgUrl.Length > 0)
            {
                //string serverPhotoPath = App_Setting.ServerPhotoPath;
                string serverPhotoPath = Path.Combine(@"C:\Shared\Images\");

                string extension = System.IO.Path.GetExtension(imgUrl);
                string name = MovieCoverName + extension;

                strString = serverPhotoPath + name;

                Bitmap orgBitmap = new Bitmap(imgUrl);
                orgBitmap.Save(strString);
                orgBitmap.Dispose();
            }
            else
            {
                strString = "";
            }
        }

        private void BtnMovieSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        public void BindDgvMovie()
        {
            try
            {
                dgvMovie.DataSource = null;
                ResMovie res = new MovieDao().GetAllMovie();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovie.DataSource = res.LstMovie;
                    LstMovieSD = res.LstMovie; //forCombobox
                    LstMovieST = res.LstMovie; //forCombobox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowImage(string fileName) //show image in datagridview
        {
            Bitmap orgBitmapImage = new Bitmap(fileName);
            pictureBox.Image = orgBitmapImage;
        }

        int id = -1;

        private void BtnMovieUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckRequireFields()) return;
                if (AnyChanges)
                {
                    EditImageFilePath(MovieCoverName);
                }
                MessageEntity res = new MovieDao().UpdateMovie(1, new DAO.Entity.Movie()
                {
                    Id = id,
                    Name = txtName.Text,
                    MovieCover = strString,
                    Casts = txtCasts.Text,
                    Runtime = txtRuntime.Text,
                    MovieType = txtMovieType.Text,
                    Description = txtDescription.Text,
                    TrailerLink = txtMovieLink.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Update Success");
                    Reset();
                    BindDgvMovie();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMovie.Rows[e.RowIndex].Cells["ColDelMovie"].ColumnIndex == e.ColumnIndex)
                {
                    int MovieCount = new MovieDao().CheckMovieBySDId(Convert.ToInt32(dgvMovie.Rows[e.RowIndex].Cells["ColIdMovie"].Value)); //Control delete Movie when date are assign
                    if (MovieCount > 0)
                    {
                        MessageBox.Show("Transaction Exists");
                        return;
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            MessageEntity res1 = new MovieDao().DeleteMovie(Convert.ToInt32(dgvMovie.Rows[e.RowIndex].Cells["ColIdMovie"].Value));
                            if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                            {
                                MessageBox.Show("Delete Success");
                                Reset();
                                BindDgvMovie();
                            }
                            else if (res1.RespMessageType == CommonResponseMessage.ResErrorType)
                            {
                                MessageBox.Show("Delete Fail");
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRowST = dgvMovie.SelectedRows[0];
            id = Convert.ToInt32(dgvRowST.Cells["ColIdMovie"].Value);
            txtName.Text = dgvRowST.Cells["ColMovieName"].Value.ToString();
            txtCasts.Text = dgvRowST.Cells["ColCasts"].Value.ToString();
            txtRuntime.Text = dgvRowST.Cells["ColRuntime"].Value.ToString();
            txtMovieType.Text = dgvRowST.Cells["ColMovieType"].Value.ToString();
            txtDescription.Text = dgvRowST.Cells["ColDescription"].Value.ToString();
            txtMovieLink.Text = dgvRowST.Cells["ColMovieLink"].Value.ToString();
            ShowImage(dgvRowST.Cells["ColMovieCoverString"].Value.ToString()); // show iamge in data grid view
            btnMovieSave.Visible = false;
            btnMovieUpdate.Visible = true;
            strString = dgvRowST.Cells["ColMovieCoverString"].Value.ToString();
            MovieCoverName = "M-" + id;
            FileStream fStream = new FileStream(strString, FileMode.Open, FileAccess.Read);
            codeImage = new byte[fStream.Length];

            fStream.Read(codeImage, 0, (Int32)fStream.Length);

            fStream.Dispose();

            pictureBox.Text = strString;
        }

        #endregion


        #region ScheduleDate

        private void ResetSD()
        {
            CbSDName.Text = "";
            txtSDStartDate.Text = "";
            txtSDEndDate.Text = "";
            btnSDUpdate.Visible = false;
            btnSDSave.Visible = true;
        }

        private void BtnSDCancel_Click(object sender, EventArgs e)
        {
            ResetSD();
        }

        private bool CheckRequireFieldsSD()
        {
            if (string.IsNullOrEmpty(CbSDName.Text))
            {
                MessageBox.Show("Choose Movie Name");
                return false;
            }
            return true;
        }

        private void BtnSDSave_Click(object sender, EventArgs e)
        {
            SaveMovieSD();
        }

        private void SaveMovieSD()
        {
            try
            {
                if (!CheckRequireFieldsSD()) return;
                MessageEntity res = new MovieSDDao().SaveMovieSD(1, new DAO.Entity.MovieSD()
                {
                    MovieId = Convert.ToInt32(CbSDName.SelectedValue),
                    StartDate = Convert.ToDateTime(txtSDStartDate.Text),
                    EndDate = Convert.ToDateTime(txtSDEndDate.Text),
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Success");
                    ResetSD();
                    BindDgvMovieSD();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BindDgvMovieSD()
        {
            try
            {
                dgvSD.DataSource = null;
                ResMovieSD res = new MovieSDDao().GetAllMovieSD();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvSD.DataSource = res.LstMovieSD;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbSDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MovieId = Convert.ToInt32(CbSDName.SelectedValue);
            ResMovie res = new MovieDao().GetMovieNameById(MovieId);
        }

        private List<Movie> LstMovieSD = new List<Movie>();
        private List<Movie> LstMovieST = new List<Movie>();

        //public List<Movie> LstMovie { get; set; }
        private void TabControlMovie_Click(object sender, EventArgs e)
        {
            if (LstMovieSD != null && LstMovieSD.Count > 0)
            {
                //Schedule date combo box
                CbSDName.SelectedIndexChanged -= new EventHandler(CbSDName_SelectedIndexChanged);
                CbSDName.DataSource = null;
                CbSDName.DataSource = LstMovieSD;
                CbSDName.DisplayMember = "Name";
                CbSDName.ValueMember = "Id";
                CbSDName.SelectedIndex = 0;
                CbSDName.SelectedIndexChanged += new EventHandler(CbSDName_SelectedIndexChanged);
                BindDgvMovieSD();
            }
            if (LstMovieST != null && LstMovieST.Count > 0)
            {
                //Schedule time combo box
                CbSTName.SelectedIndexChanged -= new EventHandler(CbSTName_SelectedIndexChanged);
                CbSTName.DataSource = null;
                CbSTName.DataSource = LstMovieST;
                CbSTName.DisplayMember = "Name";
                CbSTName.ValueMember = "Id";
                CbSTName.SelectedIndex = 0;
                CbSTName.SelectedIndexChanged += new EventHandler(CbSTName_SelectedIndexChanged);
                BindDgvMovieST();
            }

            //if (LstMovie != null && LstMovie.Count > 0)
            //{
            //    //Schedule date combo box
            //    CbSDName.SelectedIndexChanged -= new EventHandler(CbSDName_SelectedIndexChanged);
            //    CbSDName.DataSource = null;
            //    CbSDName.DataSource = LstMovie;
            //    CbSDName.DisplayMember = "Name";
            //    CbSDName.ValueMember = "Id";
            //    CbSDName.SelectedIndex = 0;
            //    CbSDName.SelectedIndexChanged += new EventHandler(CbSDName_SelectedIndexChanged);
            //    BindDgvMovieSD();

            //    CbSTName.SelectedIndexChanged -= new EventHandler(CbSTName_SelectedIndexChanged);
            //    CbSTName.DataSource = null;
            //    CbSTName.DataSource = LstMovie;
            //    CbSTName.DisplayMember = "Name";
            //    CbSTName.ValueMember = "Id";
            //    CbSTName.SelectedIndex = 0;
            //    CbSTName.SelectedIndexChanged += new EventHandler(CbSTName_SelectedIndexChanged);
            //    BindDgvMovieST();
        }

        private void CbSTName_SelectedIndexChanged(object sender, EventArgs e)
        {
            STDate.MinDate = Convert.ToDateTime("1/1/1753");
            STDate.MaxDate = Convert.ToDateTime("12/31/9998");
            int MovieId = Convert.ToInt32(CbSTName.SelectedValue);
            ResMovieSD res = new MovieDao().GetMovieDateById(MovieId);
            if (res.LstMovieSD.Count > 0) //if condition use to control error in datetime bcoz LstMovieSD have O index 
            {
                STDate.MinDate = res.LstMovieSD[0].StartDate;
                STDate.MaxDate = res.LstMovieSD[0].EndDate;
            }
        }

        int idsd = -1; int MovieId;

        private void DgvSD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSD.Rows[e.RowIndex].Cells["ColDelSD"].ColumnIndex == e.ColumnIndex)
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        MessageEntity res1 = new MovieSDDao().DeleteMovieSD(Convert.ToInt32(dgvSD.Rows[e.RowIndex].Cells["ColMovieSDId"].Value));
                        if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show("Delete Success");
                            ResetSD();
                            BindDgvMovieSD();
                        }
                        else if (res1.RespMessageType == CommonResponseMessage.ResErrorType)
                        {
                            MessageBox.Show("Delete Fail");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvSD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvSD.SelectedRows[0];
            idsd = Convert.ToInt32(dgvRow.Cells["ColMovieSDId"].Value);
            CbSDName.SelectedValue = Convert.ToInt32(dgvRow.Cells["ColMovieId"].Value.ToString());
            MovieId = Convert.ToInt32(dgvRow.Cells["ColMovieId"].Value.ToString());

            txtSDStartDate.Text = dgvRow.Cells["ColStartDate"].Value.ToString();
            txtSDEndDate.Text = dgvRow.Cells["ColEndDate"].Value.ToString();

            btnSDSave.Visible = false;
            btnSDUpdate.Visible = true;
        }

        private void BtnSDUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MessageEntity res = new MovieSDDao().UpdateMovieSD(1, new DAO.Entity.MovieSD()
                {
                    Id = idsd,
                    MovieId = MovieId,
                    StartDate = Convert.ToDateTime(txtSDStartDate.Text),
                    EndDate = Convert.ToDateTime(txtSDEndDate.Text),
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Update Success");
                    Reset();
                    BindDgvMovieSD();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #endregion


        #region Movie Schedule Time

        private void DgvST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvST.Rows[e.RowIndex].Cells["ColDelST"].ColumnIndex == e.ColumnIndex)
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        MessageEntity res1 = new MovieSTDao().DeleteMovieST(Convert.ToInt32(dgvST.Rows[e.RowIndex].Cells["ColIDST"].Value));
                        if (res1.RespMessageType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show("Delete Success");
                            ResetST();
                            BindDgvMovieST();
                        }
                        else if (res1.RespMessageType == CommonResponseMessage.ResErrorType)
                        {
                            MessageBox.Show("Delete Fail");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckRequireFieldsST()
        {
            if (string.IsNullOrEmpty(CbSTName.Text))
            {
                MessageBox.Show("Choose Movie Name");
                return false;
            }
            return true;
        }

        private void BindDgvMovieST()
        {
            try
            {
                dgvST.DataSource = null;
                ResMovieST res = new MovieSTDao().GetAllMovieST();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvST.DataSource = res.LstMovieST;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetST()
        {
            CbSTName.SelectedIndex = 0;
            STDate.Text = "";
            STTime.Text = "";
            btnSTUpdate.Visible = false;
            btnSTSave.Visible = true;
            STDate.MinDate = Convert.ToDateTime("1/1/1753");
            STDate.MaxDate = Convert.ToDateTime("12/31/9998");
        }

        private void SaveMovieST()
        {
            try
            {
                if (!CheckRequireFieldsST()) return;
                MessageEntity res = new MovieSTDao().SaveMovieST(1, new DAO.Entity.MovieST()
                {
                    MovieId = Convert.ToInt32(CbSTName.SelectedValue),
                    Date = Convert.ToDateTime(STDate.Text),
                    Time = STTime.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Success");
                    ResetST();
                    BindDgvMovieST();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnSTCancel_Click(object sender, EventArgs e)
        {
            ResetST();
        }

        private void BtnSTSave_Click(object sender, EventArgs e)
        {
            SaveMovieST();
        }


        int idst = -1;

        private void DgvST_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvST.SelectedRows[0];
            idst = Convert.ToInt32(dgvRow.Cells["ColIDST"].Value);
            CbSTName.SelectedValue = Convert.ToInt32(dgvRow.Cells["ColMovieIdST"].Value.ToString());
            MovieId = Convert.ToInt32(dgvRow.Cells["ColMovieIdST"].Value.ToString());

            STDate.Text = dgvRow.Cells["ColSTDate"].Value.ToString();
            STTime.Text = dgvRow.Cells["ColSTTime"].Value.ToString();

            btnSTSave.Visible = false;
            btnSTUpdate.Visible = true;
        }

        private void BtnSTUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MessageEntity res = new MovieSTDao().UpdateMovieST(1, new DAO.Entity.MovieST()
                {
                    Id = idst,
                    MovieId = MovieId,
                    Date = Convert.ToDateTime(STDate.Text),
                    Time = STTime.Text,
                });
                if (res.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show("Update Success");
                    ResetST();
                    BindDgvMovieST();
                }
                else if (res.RespMessageType == CommonResponseMessage.ResErrorType)
                {
                    if (res.RespDesp == "Duplicate Error")
                    {
                        MessageBox.Show("Name Already Exist");
                    }
                    else
                    {
                        MessageBox.Show("Save Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #endregion
    }

}

