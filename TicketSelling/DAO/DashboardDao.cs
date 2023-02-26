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
                        MovieCover = dt.Rows[i]["MovieCover"].ToString(),
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

        public ResMovie GetAllMovieSummary()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.SP_GetAllMovieSummary, sqlConnection);
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResMovie() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<MovieSummary> lst = new List<MovieSummary>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new MovieSummary
                    {
                        RowNumber = dt.Rows[i]["RowNumber"].ToString(),
                        MovieName = dt.Rows[i]["MovieName"].ToString(),
                        TotalAmount = Convert.ToInt32(dt.Rows[i]["TotalAmount"].ToString())
                    });
                }
                return new ResMovie()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    lstMovieSummary = lst
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
