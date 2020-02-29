using JobWorkManagement.ENT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_UserDALBase
/// </summary>
namespace JobWorkManagement.DAL
{
    public abstract class JWM_UserDALBase : DatabaseConfig
    {
        #region Local Variables

        private string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local Variables

        #region InsertOperation

        public Boolean Insert(JWM_UserENT entUser)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_User_Insert";
                        objCmd.Parameters.AddWithValue("@UserName", entUser.UserName);
                        objCmd.Parameters.AddWithValue("@Password", entUser.Password);
                        objCmd.Parameters.AddWithValue("@FullName", entUser.DisplayName);
                        objCmd.Parameters.AddWithValue("@FullName", entUser.Email);
                        objCmd.Parameters.AddWithValue("@MobileNo", entUser.MobileNo);
                        objCmd.Parameters.AddWithValue("@EmailID", entUser.Remarks);
                        objCmd.Parameters.AddWithValue("@IsActive", entUser.IsActive);
                        objCmd.Parameters.AddWithValue("@CreationDate", entUser.CreationDate);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entUser.ModifiedDate);

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion InsertOperation

        #region Update Operation

        public Boolean Update(JWM_UserENT entUser)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_User_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@UserID", entUser.UserID);
                        objCmd.Parameters.AddWithValue("@UserName", entUser.UserName);
                        objCmd.Parameters.AddWithValue("@Password", entUser.Password);
                        objCmd.Parameters.AddWithValue("@FullName", entUser.DisplayName);
                        objCmd.Parameters.AddWithValue("@Email", entUser.Email);
                        objCmd.Parameters.AddWithValue("@MobileNo", entUser.MobileNo);
                        objCmd.Parameters.AddWithValue("@Remarks", entUser.Remarks);
                        objCmd.Parameters.AddWithValue("@IsActive", entUser.IsActive);
                        objCmd.Parameters.AddWithValue("@CreationDate", entUser.CreationDate);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entUser.ModifiedDate);

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 UserID)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_User_Delete";
                        objCmd.Parameters.AddWithValue("@UserID", UserID);

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Delete Operation
    }
}