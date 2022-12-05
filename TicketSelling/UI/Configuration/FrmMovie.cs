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
            btnMovieUpdate.Visible = false;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            BindDgvMovieSD();
            BindDgvMovie();
            txtName.Select();
            txtSDStartDate.Value = DateTime.Now;
            txtSDEndDate.Value = DateTime.Now;
        }

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
                Bitmap imgOutforsaveondisk = CommonFormat.ConvertTo16bpp(CommonFormat.getResizedImage(codeImage, 1280, 720));
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

        private void BindDgvMovie()
        {
            try
            {
                dgvMovie.DataSource = null;
                ResMovie res = new MovieDao().GetAllMovie();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    dgvMovie.DataSource = res.LstMovie;
                    LstMovie = res.LstMovie; //forCombobox
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
                if (AnyChanges)
                {
                    EditImageFilePath(MovieCoverName);
                }
                if (!CheckRequireFields()) return;
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

        private void SaveDataSD()
        {
            try
            {
                if (!CheckRequireFieldsSD()) return;
                MessageEntity res = new MovieSDDao().SaveMovieSD(1, new DAO.Entity.MovieSD()
                {
                    MovieId = Convert.ToInt32(CbSDName.SelectedValue),
                    StartDate = Convert.ToDateTime(txtSDStartDate.Value),
                    EndDate = Convert.ToDateTime(txtSDEndDate.Value),
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

        private void BtnSDSave_Click(object sender, EventArgs e)
        {
            SaveDataSD();
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

        private List<Movie> LstMovie = new List<Movie>();

        private void TabControlMovie_Click(object sender, EventArgs e)
        {
            if (LstMovie != null && LstMovie.Count > 0)
            {
                CbSDName.SelectedIndexChanged -= new EventHandler(CbSDName_SelectedIndexChanged);
                CbSDName.DataSource = null;
                CbSDName.DataSource = LstMovie;
                CbSDName.DisplayMember = "Name";
                CbSDName.ValueMember = "Id";
                CbSDName.SelectedIndex = 0;
                CbSDName.SelectedIndexChanged += new EventHandler(CbSDName_SelectedIndexChanged);
                BindDgvMovieSD();
            }
        }

        #endregion

       
    }
}
