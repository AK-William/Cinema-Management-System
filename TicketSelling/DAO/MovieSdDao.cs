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
    public class MovieSDDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;

        public MessageEntity SaveMovieSD(int UserID, MovieSD req)
        {
            DataSet ds = new DataSet();
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                    scom = new SqlCommand(ProcedureConstants.SaveMovieSD, sqlConnection);
                    scom.CommandType = CommandType.Text;
                    scom.Parameters.AddWithValue("@MovieId", req.MovieId);
                    scom.Parameters.AddWithValue("@StartDate", req.StartDate);
                    scom.Parameters.AddWithValue("@EndDate", req.EndDate);
                    scom.Parameters.AddWithValue("@CreatedBy", UserID);
                    ds = new DataSet();
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

        public ResMovieSD GetAllMovieSD()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllMovieSD, sqlConnection);
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResMovieSD() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<MovieSD> lst = new List<MovieSD>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new MovieSD
                    {
                        RowNumber = dt.Rows[i]["RowNumber"].ToString(),
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        MovieId = Convert.ToInt32(dt.Rows[i]["MovieId"]),
                        Name = dt.Rows[i]["Name"].ToString(),
                        StartDate = Convert.ToDateTime(dt.Rows[i]["StartDate"].ToString()),
                        EndDate = Convert.ToDateTime(dt.Rows[i]["EndDate"].ToString()),
                    });
                }
                return new ResMovieSD()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstMovieSD = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResMovieSD() { MessageEntity = _MessageEntity };
            }
        }

        public MessageEntity DeleteMovieSD(int Id)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.DeleteMovieSD, sqlConnection);
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


        public MessageEntity UpdateMovieSD(int UserID, MovieSD req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.UpdateMovieSD, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", req.Id);
                scom.Parameters.AddWithValue("@MovieId", req.MovieId);
                scom.Parameters.AddWithValue("@StartDate", req.StartDate);
                scom.Parameters.AddWithValue("@EndDate", req.EndDate);
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


    }
}
