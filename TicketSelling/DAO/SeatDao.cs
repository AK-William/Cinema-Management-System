using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.Common;
using TicketSelling.DAO.Entity;

namespace TicketSelling.DAO
{
    public class SeatDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;

        public MessageEntity SaveSeat(int UserID, Seat req)
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
                for (int i = 1; i <= req.NumberOfSeat ; i++)
                {
                    scom = new SqlCommand(ProcedureConstants.SaveSeat, sqlConnection);
                    scom.CommandType = CommandType.Text;
                    scom.Parameters.AddWithValue("@Name", req.SeatTypeName + "-" + i);
                    scom.Parameters.AddWithValue("@Price", req.Price);
                    scom.Parameters.AddWithValue("@SeatTypeId",req.SeatTypeId);
                    scom.Parameters.AddWithValue("@CreatedBy", UserID);
                    ds = new DataSet();
                    adapter = new SqlDataAdapter(scom);
                    adapter.Fill(ds);
                }
               
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

        public ResSeat GetAllSeat()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllSeat, sqlConnection);
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResSeat() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<Seat> lst = new List<Seat>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new Seat
                    {
                        RowNumber = dt.Rows[i]["RowNumber"].ToString(),
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        SeatTypeId =Convert.ToInt32(dt.Rows[i]["SeatTypeId"]),
                        Name = dt.Rows[i]["Name"].ToString(),
                        Price = Convert.ToInt32(dt.Rows[i]["Price"].ToString()),
                        
                    });
                }
                return new ResSeat()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstSeat = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResSeat() { MessageEntity = _MessageEntity };
            }
        }

        public MessageEntity UpdateSeat(int UserID, Seat req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.DeleteSeatbySeatTypeId, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@SeatTypeId", req.SeatTypeId);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);

                for (int i = 1; i <= req.NumberOfSeat; i++)
                {
                    scom = new SqlCommand(ProcedureConstants.SaveSeat, sqlConnection);
                    scom.CommandType = CommandType.Text;
                    scom.Parameters.AddWithValue("@Name", req.SeatTypeName + "-" + i);
                    scom.Parameters.AddWithValue("@Price", req.Price);
                    scom.Parameters.AddWithValue("@SeatTypeId", req.SeatTypeId);
                    scom.Parameters.AddWithValue("@CreatedBy", UserID);
                    ds = new DataSet();
                    adapter = new SqlDataAdapter(scom);
                    adapter.Fill(ds);
                }
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

        public MessageEntity DeleteSeat(int Id)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.DeleteSeat, sqlConnection);
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

        public int GetNumberOfSeatBySeatTypeId(int SeatTypeId)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return 0;
            }
            scom = new SqlCommand(ProcedureConstants.GetNumberOfSeatBySeatTypeId, sqlConnection);
            scom.CommandType = CommandType.Text;
            scom.Parameters.AddWithValue("@SeatTypeId", SeatTypeId);
            DataSet ds = new DataSet();
            adapter = new SqlDataAdapter(scom);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            int NumberOfSeat = Convert.ToInt32(dt.Rows[0]["NumberOfSeat"]);
            sqlConnection.Close();
            return NumberOfSeat;
        }
    }
}
