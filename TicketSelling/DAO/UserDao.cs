using TicketSelling.DAO.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  TicketSelling.Common;

namespace TicketSelling.DAO
{
    public class UserDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;

        public MessageEntity SaveUser(int UserID, User req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.SP_NewUserSave, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Name", req.Name);
                scom.Parameters.AddWithValue("@Username", req.Username);
                scom.Parameters.AddWithValue("@Password", Cryptography.Encrypt(req.Password));
                scom.Parameters.AddWithValue("@PhoneNumber", req.PhoneNumber);
                scom.Parameters.AddWithValue("@Gmail", req.Gmail);
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

        public ResUser GetAllUser()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllUser, sqlConnection);
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResUser() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<User> lst = new List<User>();
             
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new User
                    {
                        RowNumber = dt.Rows[i]["RowNumber"].ToString(),
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        Name = dt.Rows[i]["Name"].ToString(),
                        Username = dt.Rows[i]["Username"].ToString(),
                        Password = dt.Rows[i]["Password"].ToString(),
                        PhoneNumber = dt.Rows[i]["PhoneNumber"].ToString(),
                        Gmail = dt.Rows[i]["Gmail"].ToString()
                    });
                }
                return new ResUser()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstUser = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResUser() { MessageEntity = _MessageEntity };
            }
        }

        public MessageEntity UpdateUser(int UserID, User req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.UpdateUser, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", req.Id);
                scom.Parameters.AddWithValue("@Name", req.Name);
                scom.Parameters.AddWithValue("@Username", req.Username);
                scom.Parameters.AddWithValue("@Password", Cryptography.Encrypt(req.Password));
                scom.Parameters.AddWithValue("@PhoneNumber", req.PhoneNumber);
                scom.Parameters.AddWithValue("@Gmail", req.PhoneNumber);
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

        public MessageEntity DeleteUser(int Id)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.DeleteUser, sqlConnection);
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

        public MessageEntity Login(User req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.LoginUser, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Username", req.Username);
                scom.Parameters.AddWithValue("@Password", Cryptography.Encrypt(req.Password));
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();
                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return _MessageEntity;

                DataTable dt = ds.Tables[0];
                _MessageEntity = SqlDataTable.Check(dt, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new MessageEntity() { RespCode = "001", RespDesp = "Invalid LoginName and Password", RespMessageType = CommonResponseMessage.ResErrorType };

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
