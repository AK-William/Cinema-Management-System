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

namespace TicketSelling.DAO
{

    public class AdminDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;

        public MessageEntity SaveAdmin(int UserID, Admin req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.SP_AdminSave, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Name", req.Name);
                scom.Parameters.AddWithValue("@RoleId", req.RoleId);
                scom.Parameters.AddWithValue("@Username", req.Username);
                scom.Parameters.AddWithValue("@Password", Cryptography.Encrypt(req.Password));
                scom.Parameters.AddWithValue("@Gmail", req.Gmail);
                scom.Parameters.AddWithValue("@PhoneNumber", req.PhoneNumber);
                scom.Parameters.AddWithValue("@NRC", req.NRC);
                scom.Parameters.AddWithValue("@Address", req.Address);
                scom.Parameters.AddWithValue("@City", req.City);
                scom.Parameters.AddWithValue("@Postcode", req.Postcode);
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

                    AdminId = Convert.ToInt32(ds.Tables[1].Rows[0]["Id"].ToString()),
                    AdminPhotoName = "A-" + ds.Tables[1].Rows[0]["Id"].ToString()
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

        public MessageEntity UpdateAdminPhoto(Admin req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.UpdateAdminPhoto, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", req.Id);
                scom.Parameters.AddWithValue("@Photo", req.Photo);
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

                    AdminId = Convert.ToInt32(ds.Tables[1].Rows[0]["Id"].ToString()),
                    AdminPhotoName = "A-" + ds.Tables[1].Rows[0]["Id"].ToString()
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

        public ResAdmin GetAllAdmin(int RoleId, int LoginId)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllAdmin, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@RoleId", RoleId);
                scom.Parameters.AddWithValue("@LoginId", LoginId);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResAdmin() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<Admin> lst = new List<Admin>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new Admin
                    {
                        RowNumber = dt.Rows[i]["RowNumber"].ToString(),
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        RoleId = Convert.ToInt32(dt.Rows[i]["RoleId"].ToString()),
                        RoleName = dt.Rows[i]["RoleName"].ToString(),
                        Name = dt.Rows[i]["Name"].ToString(),
                        Username = dt.Rows[i]["Username"].ToString(),
                        Photo = dt.Rows[i]["Photo"].ToString(),
                        PhotoByte = File.ReadAllBytes(dt.Rows[i]["Photo"].ToString()),
                        Password = dt.Rows[i]["Password"].ToString(),
                        Gmail = dt.Rows[i]["Gmail"].ToString(),
                        PhoneNumber = dt.Rows[i]["PhoneNumber"].ToString(),
                        NRC = dt.Rows[i]["NRC"].ToString(),
                        Address = dt.Rows[i]["Address"].ToString(),
                        City = dt.Rows[i]["City"].ToString(),
                        Postcode = dt.Rows[i]["Postcode"].ToString(),
                    });
                }
                return new ResAdmin()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstAdmin = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResAdmin() { MessageEntity = _MessageEntity };
            }
        }

        public MessageEntity UpdateAdmin(int UserID, Admin req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.UpdateAdmin, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", req.Id);
                scom.Parameters.AddWithValue("@Photo", req.Photo);
                scom.Parameters.AddWithValue("@RoleId", req.RoleId);
                scom.Parameters.AddWithValue("@Name", req.Name);
                scom.Parameters.AddWithValue("@Username", req.Username);
                scom.Parameters.AddWithValue("@Password", Cryptography.Encrypt(req.Password));
                scom.Parameters.AddWithValue("@Gmail", req.Gmail);
                scom.Parameters.AddWithValue("@PhoneNumber", req.PhoneNumber);
                scom.Parameters.AddWithValue("@NRC", req.NRC);
                scom.Parameters.AddWithValue("@Address", req.Address);
                scom.Parameters.AddWithValue("@City", req.City);
                scom.Parameters.AddWithValue("@Postcode", req.Postcode);
                scom.Parameters.AddWithValue("@UserId", UserID); //modifiedby id 
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

        public MessageEntity DeleteAdmin(int Id)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.DeleteAdmin, sqlConnection);
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

        //public MessageEntity Login(Admin req)
        //{
        //    sqlConnection = DbConnector.Connect();
        //    if (sqlConnection == null)
        //    {
        //        return null;
        //    }
        //    MessageEntity _MessageEntity = null;
        //    try
        //    {
        //        scom = new SqlCommand(ProcedureConstants.Login, sqlConnection);
        //        scom.CommandType = CommandType.Text;
        //        scom.Parameters.AddWithValue("@Username", req.Username);
        //        scom.Parameters.AddWithValue("@Password", Cryptography.Encrypt(req.Password));
        //        DataSet ds = new DataSet();
        //        adapter = new SqlDataAdapter(scom);
        //        adapter.Fill(ds);
        //        sqlConnection.Close();
        //        _MessageEntity = SqlDataSet.Check(ds, 1);
        //        if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
        //            return _MessageEntity;

        //        DataTable dt = ds.Tables[0];
        //        _MessageEntity = SqlDataTable.Check(dt, 1);
        //        if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
        //            return new MessageEntity() { RespCode = "001", RespDesp = "Invalid LoginName and Password", RespMessageType = CommonResponseMessage.ResErrorType };

        //        dt = ds.Tables[0];

        //        return new MessageEntity()
        //        {
        //            RespCode = dt.Rows[0]["RespCode"].ToString(),
        //            RespDesp = dt.Rows[0]["RespDesp"].ToString(),
        //            RespMessageType = dt.Rows[0]["RespMessageType"].ToString()
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
        //        _MessageEntity.RespDesp = ex.Message;
        //        _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
        //        return _MessageEntity;
        //    }
        //}

        public ResAdmin Login(Admin req)
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.Login, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Username", req.Username);
                scom.Parameters.AddWithValue("@Password", Cryptography.Encrypt(req.Password));
                //scom.Parameters.AddWithValue("@Password", req.Password);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResAdmin() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<Admin> lst = new List<Admin>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new Admin
                    {
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        RoleId = Convert.ToInt32(dt.Rows[i]["RoleId"].ToString()),
                        Name = dt.Rows[i]["Name"].ToString(),
                        Username = dt.Rows[i]["Username"].ToString(),
                        Photo = dt.Rows[i]["Photo"].ToString(),
                        PhotoByte = File.ReadAllBytes(dt.Rows[i]["Photo"].ToString()),
                    });
                }
                return new ResAdmin()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstAdmin = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResAdmin() { MessageEntity = _MessageEntity };
            }
        }

        public bool CheckUserRoleById(int Id)  //Control delete when only one admin
        {
            sqlConnection = DbConnector.Connect();
            bool IsDeleteUser = true;
            if (sqlConnection == null)
            {
                return false;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                int UserCount = 0;
                int RoleId = 0;
                scom = new SqlCommand(ProcedureConstants.CheckUserRoleAndCountById, sqlConnection);
                scom.CommandType = CommandType.Text;
                scom.Parameters.AddWithValue("@Id", Id);
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                DataTable dt1 = ds.Tables[1];
                UserCount = Convert.ToInt32(dt.Rows[0][0]);
                RoleId = Convert.ToInt32(dt1.Rows[0][0]);
                if (RoleId == 1 && UserCount == 1)
                {
                    IsDeleteUser = false;
                }
                sqlConnection.Close();
                return IsDeleteUser;
            }
            catch
            {
                return true;
            }
        }


    }
}
