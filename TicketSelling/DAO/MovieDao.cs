using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.Common;
using TicketSelling.DAO.Entity;
using System.IO;

namespace TicketSelling.DAO
{

    public class MovieDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;

        public MessageEntity SaveMovie(int UserID, Movie req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.SP_MovieSave, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Name", req.Name);
                //scom.Parameters.AddWithValue("@MovieCover", req.MovieCover);
                scom.Parameters.AddWithValue("@Casts", req.Casts);
                scom.Parameters.AddWithValue("@Runtime", req.Runtime);
                scom.Parameters.AddWithValue("@MovieType", req.MovieType);
                scom.Parameters.AddWithValue("@Description", req.Description);
                scom.Parameters.AddWithValue("@TrailerLink", req.TrailerLink);
                scom.Parameters.AddWithValue("@CreatedBy", UserID);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();
                _MessageEntity = SqlDataSet.Check(ds, 2);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return _MessageEntity;

                DataTable dt = ds.Tables[1];

                _MessageEntity = SqlDataTable.Check(dt, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new MessageEntity() { RespCode = "001", RespDesp = "Saving Error!", RespMessageType = CommonResponseMessage.ResErrorType };

                dt = ds.Tables[0];

                return new MessageEntity()
                {
                    RespCode = dt.Rows[0]["RespCode"].ToString(),
                    RespDesp = dt.Rows[0]["RespDesp"].ToString(),
                    RespMessageType = dt.Rows[0]["RespMessageType"].ToString(),
                    MovieId = Convert.ToInt32(ds.Tables[1].Rows[0]["Id"].ToString()),
                    MovieCoverName = "M-" + ds.Tables[1].Rows[0]["Id"].ToString()
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return _MessageEntity;
            }
        }

        public MessageEntity UpdateMovieCover(Movie req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.UpdateMovieCover, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", req.Id);
                scom.Parameters.AddWithValue("@MovieCover", req.MovieCover);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();
                _MessageEntity = SqlDataSet.Check(ds, 2);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return _MessageEntity;

                DataTable dt = ds.Tables[1];

                _MessageEntity = SqlDataTable.Check(dt, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new MessageEntity() { RespCode = "001", RespDesp = "Saving Error!", RespMessageType = CommonResponseMessage.ResErrorType };

                dt = ds.Tables[0];

                return new MessageEntity()
                {
                    RespCode = dt.Rows[0]["RespCode"].ToString(),
                    RespDesp = dt.Rows[0]["RespDesp"].ToString(),
                    RespMessageType = dt.Rows[0]["RespMessageType"].ToString(),
                    MovieId = Convert.ToInt32(ds.Tables[1].Rows[0]["Id"].ToString()),
                    MovieCoverName = "M-" + ds.Tables[1].Rows[0]["Id"].ToString()
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return _MessageEntity;
            }
        }

        public ResMovie GetAllMovie()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllMovie, sqlConnection);
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResMovie() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<Movie> lst = new List<Movie>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new Movie
                    {
                        RowNumber = dt.Rows[i]["RowNumber"].ToString(),
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        Name = dt.Rows[i]["Name"].ToString(),
                        MovieCover= dt.Rows[i]["MovieCover"].ToString(),
                        MovieCoverByte = File.ReadAllBytes(dt.Rows[i]["MovieCover"].ToString()),
                        Casts = dt.Rows[i]["Casts"].ToString(),
                        Runtime = dt.Rows[i]["Runtime"].ToString(),
                        MovieType = dt.Rows[i]["MovieType"].ToString(),
                        Description = dt.Rows[i]["Description"].ToString(),
                        TrailerLink = dt.Rows[i]["TrailerLink"].ToString(),
                    });
                }
                return new ResMovie()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstMovie = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResMovie() { MessageEntity = _MessageEntity };
            }
        }

        public MessageEntity UpdateMovie(int UserID, Movie req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.UpdateMovie, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", req.Id);
                scom.Parameters.AddWithValue("@Name", req.Name);
                scom.Parameters.AddWithValue("@MovieCover", req.MovieCover);
                scom.Parameters.AddWithValue("@Casts", req.Casts);
                scom.Parameters.AddWithValue("@Runtime", req.Runtime);
                scom.Parameters.AddWithValue("@MovieType", req.MovieType);
                scom.Parameters.AddWithValue("@Description", req.Description);
                scom.Parameters.AddWithValue("@TrailerLink", req.TrailerLink);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();
                _MessageEntity = SqlDataSet.Check(ds, 2);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return _MessageEntity;

                DataTable dt = ds.Tables[1];
                _MessageEntity = SqlDataTable.Check(dt, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new MessageEntity() { RespCode = "001", RespDesp = "Saving Error!", RespMessageType = CommonResponseMessage.ResErrorType };

                dt = ds.Tables[0];

                return new MessageEntity()
                {
                    RespCode = dt.Rows[0]["RespCode"].ToString(),
                    RespDesp = dt.Rows[0]["RespDesp"].ToString(),
                    RespMessageType = dt.Rows[0]["RespMessageType"].ToString()
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return _MessageEntity;
            }
        }

        public MessageEntity DeleteMovie(int Id)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.DeleteMovie, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", Id);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();
                _MessageEntity = SqlDataSet.Check(ds, 2);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return _MessageEntity;

                DataTable dt = ds.Tables[1];
                _MessageEntity = SqlDataTable.Check(dt, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new MessageEntity() { RespCode = "001", RespDesp = "Delete Error!", RespMessageType = CommonResponseMessage.ResErrorType };

                dt = ds.Tables[0];

                return new MessageEntity()
                {
                    RespCode = dt.Rows[0]["RespCode"].ToString(),
                    RespDesp = dt.Rows[0]["RespDesp"].ToString(),
                    RespMessageType = dt.Rows[0]["RespMessageType"].ToString()
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return _MessageEntity;
            }
        }

        public ResMovie GetMovieNameById(int MovieId)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetMovieNameById, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", MovieId);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResMovie() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<Movie> lst = new List<Movie>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new Movie
                    {
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        Name = dt.Rows[i]["Name"].ToString(),
                    });
                }
                return new ResMovie()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstMovie = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResMovie() { MessageEntity = _MessageEntity };
            }
        }
    }
}
