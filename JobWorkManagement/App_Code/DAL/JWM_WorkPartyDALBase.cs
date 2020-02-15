    using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_WorkPartyDALBase
/// </summary>
namespace JobWorkManagement.DAL
{
    public abstract class JWM_WorkPartyDALBase:DatabaseConfig
    {
        #region Local Variables

        protected string _Message;
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

        #region Insert Operation

        public Boolean Insert(JWM_WorkPartyENT entWorkParty)
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
                        objCmd.CommandText = "PR_JWM_WorkParty_Insert";
                        objCmd.Parameters.AddWithValue("@WorkPartyName", entWorkParty.WorkPartyName);
                        objCmd.Parameters.AddWithValue("@Address", entWorkParty.Address);
                        objCmd.Parameters.AddWithValue("@Email", entWorkParty.Email);
                        objCmd.Parameters.AddWithValue("@MobileNo", entWorkParty.MobileNo);
                        objCmd.Parameters.AddWithValue("@Remarks", entWorkParty.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entWorkParty.UserID);
                        objCmd.Parameters.AddWithValue("@CreationDate", entWorkParty.CreationDate);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entWorkParty.ModifiedDate);
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

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(JWM_WorkPartyENT entWorkParty)
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
                        objCmd.CommandText = "PR_JWM_WorkParty_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@WorkPartyID", entWorkParty.WorkPartyID);
                        objCmd.Parameters.AddWithValue("@WorkPartyName", entWorkParty.WorkPartyName);
                        objCmd.Parameters.AddWithValue("@Address", entWorkParty.Address);
                        objCmd.Parameters.AddWithValue("@Email", entWorkParty.Email);
                        objCmd.Parameters.AddWithValue("@MobileNo", entWorkParty.MobileNo);
                        objCmd.Parameters.AddWithValue("@Remarks", entWorkParty.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entWorkParty.UserID);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entWorkParty.ModifiedDate);
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

        public Boolean Delete(SqlInt32 WorkPartyID)
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
                        objCmd.CommandText = "PR_JWM_WorkParty_DeleteByPK";
                        objCmd.Parameters.AddWithValue("@WorkPartyID", WorkPartyID);
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

        #region Select Operations

        public DataTable SelectAll()
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
                        objCmd.CommandText = "PR_JWM_WorkParty_SelectAll";
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;

                        #endregion ReadData and Set Controls
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        public JWM_WorkPartyENT SelectByPK(SqlInt32 WorkPartyID)
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
                        objCmd.CommandText = "PR_JWM_WorkParty_SelectByPk";
                        objCmd.Parameters.AddWithValue("@WorkPartyID", WorkPartyID);
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        JWM_WorkPartyENT entWorkParty = new JWM_WorkPartyENT();

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["WorkPartyID"].Equals(DBNull.Value))
                                {
                                    entWorkParty.WorkPartyID = Convert.ToInt32(objSDR["WorkPartyID"]);
                                }
                                if (!objSDR["WorkPartyName"].Equals(DBNull.Value))
                                {
                                    entWorkParty.WorkPartyName = Convert.ToString(objSDR["WorkPartyName"]);
                                }
                                if (!objSDR["Address"].Equals(DBNull.Value))
                                {
                                    entWorkParty.Address = Convert.ToString(objSDR["Address"]);
                                }
                                if (!objSDR["Email"].Equals(DBNull.Value))
                                {
                                    entWorkParty.Email = Convert.ToString(objSDR["Email"]);
                                }if (!objSDR["MobileNo"].Equals(DBNull.Value))
                                {
                                    entWorkParty.MobileNo = Convert.ToString(objSDR["MobileNo"]);
                                }
                                if (!objSDR["Remarks"].Equals(DBNull.Value))
                                {
                                    entWorkParty.Remarks = Convert.ToString(objSDR["Remarks"]);
                                }
                                if (!objSDR["CreationDate"].Equals(DBNull.Value))
                                {
                                    entWorkParty.CreationDate = Convert.ToDateTime(objSDR["CreationDate"]);
                                }
                                if (!objSDR["ModifiedDate"].Equals(DBNull.Value))
                                {
                                    entWorkParty.ModifiedDate = Convert.ToDateTime(objSDR["ModifiedDate"]);
                                }
                            }
                        }
                        return entWorkParty;

                        #endregion ReadData and Set Controls
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        public DataTable SelectView(SqlInt32 WorkPartyID)
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
                        objCmd.CommandText = "PR_JWM_WorkParty_SelectView";
                        objCmd.Parameters.AddWithValue("@WorkPartyID", WorkPartyID);
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;

                        #endregion ReadData and Set Controls
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        public DataTable SelectDropDownList()
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
                        objCmd.CommandText = "PR_JWM_WorkParty_SelectByDropDownList";
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;

                        #endregion ReadData and Set Controls
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Select Operations
    }
}