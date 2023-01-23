using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;
using TicketSelling.Entity;

namespace TicketSelling.DAO
{

    public class SaleDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;

        public MessageEntity SaveSaleData(int UserID, SaleHead req)
        {
            sqlConnection = DbConnector.Connect();
            DataSet ds1 = new DataSet();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.SaveSaleHead, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@MovieId", req.MovieId);
                scom.Parameters.AddWithValue("@MovieDate", req.MovieDate);
                scom.Parameters.AddWithValue("@MovieTime", req.MovieTime);
                scom.Parameters.AddWithValue("@CustomerName", req.CustomerName);
                scom.Parameters.AddWithValue("@Phone", req.Phone);
                scom.Parameters.AddWithValue("@TotalPrice", req.TotalPrice);
                scom.Parameters.AddWithValue("@CreatedBy", UserID);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                int HeadId = Convert.ToInt32(dt.Rows[0]["Id"]);

                for (int i = 0; i < req.lstSaleDetail.Count; i++)
                {
                    var item = req.lstSaleDetail[i];
                    scom = new SqlCommand(ProcedureConstants.SaveSaleDetail, sqlConnection);
                    scom.CommandType = CommandType.Text;
                    scom.Parameters.AddWithValue("@HeadId", HeadId);
                    scom.Parameters.AddWithValue("@SeatTypeId", item.SeatTypeId);
                    scom.Parameters.AddWithValue("@SeatId", item.SeatId);
                    scom.Parameters.AddWithValue("@Price", item.Price);
                    ds1 = new DataSet();
                    adapter = new SqlDataAdapter(scom);
                    adapter.Fill(ds1);
                }

                sqlConnection.Close();
                _MessageEntity = SqlDataSet.Check(ds1, 2);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return _MessageEntity;

                DataTable dt1 = ds1.Tables[0];

                _MessageEntity = SqlDataTable.Check(dt1, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new MessageEntity() { RespCode = "001", RespDesp = "Saving Error!", RespMessageType = CommonResponseMessage.ResErrorType };

                return new MessageEntity()
                {
                    RespCode = dt1.Rows[0]["RespCode"].ToString(),
                    RespDesp = dt1.Rows[0]["RespDesp"].ToString(),
                    RespMessageType = dt1.Rows[0]["RespMessageType"].ToString(),
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

        public ResSale GetSellingTicket(int MovieId, DateTime MovieDate, int TimeId)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetSellingTicket, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@MovieId", MovieId);
                scom.Parameters.AddWithValue("@MovieDate", MovieDate);
                scom.Parameters.AddWithValue("@MovieTime", TimeId);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResSale() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<SaleDetail> lst = new List<SaleDetail>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new SaleDetail
                    {
                        HeadId = Convert.ToInt32(dt.Rows[i]["HeadId"].ToString()),
                        SeatTypeId = Convert.ToInt32(dt.Rows[i]["SeatTypeId"].ToString()),
                        SeatId = Convert.ToInt32(dt.Rows[i]["SeatId"].ToString()),
                        Price = Convert.ToInt32(dt.Rows[i]["Price"].ToString())
                    });
                }
                return new ResSale()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    lstSaleDetail = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResSale() { MessageEntity = _MessageEntity };
            }
        }

        public ResSale GetSaleReportByDate(string str,int MovieId,DateTime StartDate, Nullable<DateTime> EndDate=null)
        {
            MessageEntity _MessageEntity = null;
            sqlConnection = DbConnector.Connect();
            try
            {
                scom = new SqlCommand(str, sqlConnection);
                scom.CommandType = CommandType.Text;
                if (StartDate != null && EndDate == null)
                {
                    scom.Parameters.AddWithValue("@StartDate", StartDate);
                }
                else
                {
                    scom.Parameters.AddWithValue("@StartDate", StartDate);
                    scom.Parameters.AddWithValue("@EndDate", EndDate);
                }
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();
                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResSale() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<SaleReport> lst = new List<SaleReport>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SaleReport item = new SaleReport();
                    item.MovieName = dt.Rows[i]["MovieName"].ToString();
                    item.MovieDate = Convert.ToDateTime(dt.Rows[i]["MovieDate"].ToString());
                    item.MovieTime = dt.Rows[i]["MovieTime"].ToString();
                    item.SeatName = dt.Rows[i]["SeatName"].ToString();
                    item.Price = Convert.ToInt32(dt.Rows[i]["TotalPassenger"].ToString());
                    lst.Add(item);
                }
                return new ResSale()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    lstSaleReport = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResSale() { MessageEntity = _MessageEntity };
            }
        }

    }
}
