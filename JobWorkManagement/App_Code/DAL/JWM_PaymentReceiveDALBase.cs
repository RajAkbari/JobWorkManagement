using JobWorkManagement.ENT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_PaymentReceiveDALBase
/// </summary>
namespace JobWorkManagement.DAL
{
    public abstract class JWM_PaymentReceiveDALBase : DatabaseConfig
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

        public Boolean Insert(JWM_PaymentReceiveENT entPaymentReceive)
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
                        objCmd.CommandText = "PR_JWM_PaymentReceive_Insert";
                        objCmd.Parameters.AddWithValue("@WorkPartyID", entPaymentReceive.WorkPartyID);
                        objCmd.Parameters.AddWithValue("@PaymentReceiveDate", entPaymentReceive.PaymentReceiveDate);
                        objCmd.Parameters.AddWithValue("@Amount", entPaymentReceive.Amount);
                        objCmd.Parameters.AddWithValue("@Remarks", entPaymentReceive.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entPaymentReceive.UserID);
                        objCmd.Parameters.AddWithValue("@CreationDate", entPaymentReceive.CreationDate);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entPaymentReceive.ModifiedDate);

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

        public Boolean Update(JWM_PaymentReceiveENT entPaymentReceive)
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
                        objCmd.CommandText = "PR_JWM_PaymentReceive_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@PaymentReceiveID", entPaymentReceive.PaymentReceiveID);
                        objCmd.Parameters.AddWithValue("@WorkPartyID", entPaymentReceive.WorkPartyID);
                        objCmd.Parameters.AddWithValue("@PaymentReceiveDate", entPaymentReceive.PaymentReceiveDate);
                        objCmd.Parameters.AddWithValue("@Amount", entPaymentReceive.Amount);
                        objCmd.Parameters.AddWithValue("@Remarks", entPaymentReceive.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entPaymentReceive.UserID);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entPaymentReceive.ModifiedDate);

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

        public Boolean Delete(SqlInt32 PaymentReceiveID)
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
                        objCmd.CommandText = "PR_JWM_PaymentReceive_DeleteByPK";
                        objCmd.Parameters.AddWithValue("@PaymentReceiveID", PaymentReceiveID);

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
                        objCmd.CommandText = "PR_JWM_PaymentReceive_SelectAll";

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

        public JWM_PaymentReceiveENT SelectByPK(SqlInt32 PaymentReceiveID)
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
                        objCmd.CommandText = "PR_JWM_PaymentReceive_SelectByPK";
                        objCmd.Parameters.AddWithValue("@PaymentReceiveID", PaymentReceiveID);

                        #endregion Prepare Command

                        #region ReadData and Set Controls

                        JWM_PaymentReceiveENT entPaymentReceive = new JWM_PaymentReceiveENT();

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["PaymentReceiveID"].Equals(DBNull.Value))
                                {
                                    entPaymentReceive.PaymentReceiveID = Convert.ToInt32(objSDR["PaymentReceiveID"]);
                                }
                                if (!objSDR["PaymentReceiveDate"].Equals(DBNull.Value))
                                {
                                    entPaymentReceive.PaymentReceiveDate = Convert.ToDateTime(objSDR["PaymentReceiveDate"]);
                                }
                                if (!objSDR["WorkPartyID"].Equals(DBNull.Value))
                                {
                                    entPaymentReceive.WorkPartyID = Convert.ToInt32(objSDR["WorkPartyID"]);
                                }
                                if (!objSDR["Amount"].Equals(DBNull.Value))
                                {
                                    entPaymentReceive.Amount = Convert.ToInt32(objSDR["Amount"]);
                                }
                                if (!objSDR["Remarks"].Equals(DBNull.Value))
                                {
                                    entPaymentReceive.Remarks = Convert.ToString(objSDR["Remarks"]);
                                }
                                if (!objSDR["CreationDate"].Equals(DBNull.Value))
                                {
                                    entPaymentReceive.CreationDate = Convert.ToDateTime(objSDR["CreationDate"]);
                                }
                                if (!objSDR["ModifiedDate"].Equals(DBNull.Value))
                                {
                                    entPaymentReceive.ModifiedDate = Convert.ToDateTime(objSDR["ModifiedDate"]);
                                }
                            }
                        }
                        return entPaymentReceive;

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

        public DataTable SelectView(SqlInt32 PaymentReceiveID)
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
                        objCmd.CommandText = "PR_JWM_PaymentReceive_SelectView";
                        objCmd.Parameters.AddWithValue("@PaymentReceiveID", PaymentReceiveID);

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