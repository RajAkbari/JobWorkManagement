using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_WorkReceiveDALBase
/// </summary>
namespace JobWorkManagement.DAL
{
    public abstract class JWM_JobWorkReceiveDALBase:DatabaseConfig
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

        public Boolean Insert(JWM_JobWorkReceiveENT entJobWorkReceive)
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
                        objCmd.CommandText = "PR_JWM_JobWorkReceive_Insert";
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveDate", entJobWorkReceive.JobWorkReceiveDate);
                        objCmd.Parameters.AddWithValue("@JobTypeID", entJobWorkReceive.JobTypeID);
                        objCmd.Parameters.AddWithValue("@WorkPartyID", entJobWorkReceive.WorkPartyID);
                        objCmd.Parameters.AddWithValue("@QuantityReceived", entJobWorkReceive.QuantityReceived);
                        objCmd.Parameters.AddWithValue("@QuantityDamaged", entJobWorkReceive.QuantityDamaged);
                        objCmd.Parameters.AddWithValue("@QuantityActual", entJobWorkReceive.QuantityActual);
                        objCmd.Parameters.AddWithValue("@EstimatedDeliveryDate", entJobWorkReceive.EstimatedDeliveryDate);
                        objCmd.Parameters.AddWithValue("@Rate", entJobWorkReceive.Rate);
                        objCmd.Parameters.AddWithValue("@TotalAmount", entJobWorkReceive.TotalAmount);
                        objCmd.Parameters.AddWithValue("@IsActive", entJobWorkReceive.IsActive);
                        objCmd.Parameters.AddWithValue("@Remarks", entJobWorkReceive.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entJobWorkReceive.UserID);
                        objCmd.Parameters.AddWithValue("@CreationDate", entJobWorkReceive.CreationDate);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entJobWorkReceive.ModifiedDate);
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

        public Boolean Update(JWM_JobWorkReceiveENT entJobWorkReceive)
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
                        objCmd.CommandText = "PR_JWM_JobWorkReceive_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveID", entJobWorkReceive.JobWorkReceiveID);
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveDate", entJobWorkReceive.JobWorkReceiveDate);
                        objCmd.Parameters.AddWithValue("@JobTypeID", entJobWorkReceive.JobTypeID);
                        objCmd.Parameters.AddWithValue("@WorkPartyID", entJobWorkReceive.WorkPartyID);
                        objCmd.Parameters.AddWithValue("@QuantityReceived", entJobWorkReceive.QuantityReceived);
                        objCmd.Parameters.AddWithValue("@QuantityDamaged", entJobWorkReceive.QuantityDamaged);
                        objCmd.Parameters.AddWithValue("@QuantityActual", entJobWorkReceive.QuantityActual);
                        objCmd.Parameters.AddWithValue("@EstimatedDeliveryDate", entJobWorkReceive.EstimatedDeliveryDate);
                        objCmd.Parameters.AddWithValue("@Rate", entJobWorkReceive.Rate);
                        objCmd.Parameters.AddWithValue("@TotalAmount", entJobWorkReceive.TotalAmount);
                        objCmd.Parameters.AddWithValue("@IsActive", entJobWorkReceive.IsActive);
                        objCmd.Parameters.AddWithValue("@Remarks", entJobWorkReceive.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entJobWorkReceive.UserID);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entJobWorkReceive.ModifiedDate);


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

        public Boolean Delete(SqlInt32 JobWorkReceiveID)
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
                        objCmd.CommandText = "PR_JWM_JobWorkReceive_DeleteByPK";
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveID", JobWorkReceiveID);
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
                        objCmd.CommandText = "PR_JWM_JobWorkReceive_SelectAll";
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

        public JWM_JobWorkReceiveENT SelectByPK(SqlInt32 JobWorkReceiveID)
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
                        objCmd.CommandText = "PR_JWM_JobWorkReceive_SelectByPK";
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveID", JobWorkReceiveID);
                        #endregion Prepare Command

                        #region ReadData and Set Controls
                        JWM_JobWorkReceiveENT entJobWorkReceive = new JWM_JobWorkReceiveENT();

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["JobWorkReceiveID"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.JobWorkReceiveID = Convert.ToInt32(objSDR["JobWorkReceiveID"]);
                                }
                                if (!objSDR["JobWorkReceiveDate"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.JobWorkReceiveDate = Convert.ToDateTime(objSDR["JobWorkReceiveDate"]);
                                }
                                if (!objSDR["JobTypeID"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.JobTypeID = Convert.ToInt32(objSDR["JobTypeID"]);
                                }
                                if (!objSDR["WorkPartyID"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.WorkPartyID = Convert.ToInt32(objSDR["WorkPartyID"]);
                                }
                                if (!objSDR["QuantityReceived"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.QuantityReceived = Convert.ToInt32(objSDR["QuantityReceived"]);
                                }
                                if (!objSDR["QuantityDamaged"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.QuantityDamaged = Convert.ToInt32(objSDR["QuantityDamaged"]);
                                }
                                if (!objSDR["QuantityActual"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.QuantityActual = Convert.ToInt32(objSDR["QuantityActual"]);
                                }
                                if (!objSDR["EstimatedDeliveryDate"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.EstimatedDeliveryDate = Convert.ToDateTime(objSDR["EstimatedDeliveryDate"]);
                                }
                                if (!objSDR["Rate"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.Rate = Convert.ToDecimal(objSDR["Rate"]);
                                }
                                if (!objSDR["TotalAmount"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.TotalAmount = Convert.ToDecimal(objSDR["TotalAmount"]);
                                }
                                if (!objSDR["IsActive"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.IsActive = Convert.ToBoolean(objSDR["IsActive"]);
                                }
                                if (!objSDR["Remarks"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.Remarks = Convert.ToString(objSDR["Remarks"]);
                                }
                                if (!objSDR["CreationDate"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.CreationDate = Convert.ToDateTime(objSDR["CreationDate"]);
                                }
                                if (!objSDR["ModifiedDate"].Equals(DBNull.Value))
                                {
                                    entJobWorkReceive.ModifiedDate = Convert.ToDateTime(objSDR["ModifiedDate"]);
                                }
                            }
                        }
                        return entJobWorkReceive;

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

        public DataTable SelectView(SqlInt32 JobWorkReceiveID)
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
                        objCmd.CommandText = "PR_JWM_JobWorkReceive_SelectView";
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveID", JobWorkReceiveID);
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

        public DataTable SelectDropDownList(SqlInt32 WorkPartyID)
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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_DropDownListByWorkPartyID";
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

        #endregion Select Operations
    }
}