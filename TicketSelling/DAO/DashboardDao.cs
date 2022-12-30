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

    public class DashboardDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;


        public ResMovie GetAllMovieDB1()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllMovieDB, sqlConnection);
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

                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                lst.Add(new Movie
                {
                    RowNumber = dt.Rows[0]["RowNumber"].ToString(),
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Name = dt.Rows[0]["Name"].ToString(),
                    MovieCover = dt.Rows[0]["MovieCover"].ToString(),
                    MovieCoverByte = File.ReadAllBytes(dt.Rows[0]["MovieCover"].ToString()),
                    Casts = dt.Rows[0]["Casts"].ToString(),
                    Runtime = dt.Rows[0]["Runtime"].ToString(),
                    MovieType = dt.Rows[0]["MovieType"].ToString(),
                    Description = dt.Rows[0]["Description"].ToString(),
                    TrailerLink = dt.Rows[0]["TrailerLink"].ToString(),
                });
                //}
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

        public ResMovie GetAllMovieDB2()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllMovieDB, sqlConnection);
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

                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                lst.Add(new Movie
                {
                    RowNumber = dt.Rows[1]["RowNumber"].ToString(),
                    Id = Convert.ToInt32(dt.Rows[1]["Id"]),
                    Name = dt.Rows[1]["Name"].ToString(),
                    MovieCover = dt.Rows[1]["MovieCover"].ToString(),
                    MovieCoverByte = File.ReadAllBytes(dt.Rows[1]["MovieCover"].ToString()),
                    Casts = dt.Rows[1]["Casts"].ToString(),
                    Runtime = dt.Rows[1]["Runtime"].ToString(),
                    MovieType = dt.Rows[1]["MovieType"].ToString(),
                    Description = dt.Rows[1]["Description"].ToString(),
                    TrailerLink = dt.Rows[1]["TrailerLink"].ToString(),
                });
                //}
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

        public ResMovie GetAllMovieDB3()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllMovieDB, sqlConnection);
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

                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                lst.Add(new Movie
                {
                    RowNumber = dt.Rows[2]["RowNumber"].ToString(),
                    Id = Convert.ToInt32(dt.Rows[2]["Id"]),
                    Name = dt.Rows[2]["Name"].ToString(),
                    MovieCover = dt.Rows[2]["MovieCover"].ToString(),
                    MovieCoverByte = File.ReadAllBytes(dt.Rows[2]["MovieCover"].ToString()),
                    Casts = dt.Rows[2]["Casts"].ToString(),
                    Runtime = dt.Rows[2]["Runtime"].ToString(),
                    MovieType = dt.Rows[2]["MovieType"].ToString(),
                    Description = dt.Rows[2]["Description"].ToString(),
                    TrailerLink = dt.Rows[2]["TrailerLink"].ToString(),
                });
                //}
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

        public ResMovie GetAllMovieDB4()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllMovieDB, sqlConnection);
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

                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                lst.Add(new Movie
                {
                    RowNumber = dt.Rows[3]["RowNumber"].ToString(),
                    Id = Convert.ToInt32(dt.Rows[3]["Id"]),
                    Name = dt.Rows[3]["Name"].ToString(),
                    MovieCover = dt.Rows[3]["MovieCover"].ToString(),
                    MovieCoverByte = File.ReadAllBytes(dt.Rows[3]["MovieCover"].ToString()),
                    Casts = dt.Rows[3]["Casts"].ToString(),
                    Runtime = dt.Rows[3]["Runtime"].ToString(),
                    MovieType = dt.Rows[3]["MovieType"].ToString(),
                    Description = dt.Rows[3]["Description"].ToString(),
                    TrailerLink = dt.Rows[3]["TrailerLink"].ToString(),
                });
                //}
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
