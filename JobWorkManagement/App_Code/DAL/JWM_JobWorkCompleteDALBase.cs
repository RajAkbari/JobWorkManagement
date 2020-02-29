using JobWorkManagement.ENT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_WorkCompleteDALBase
/// </summary>
namespace JobWorkManagement.DAL
{
    public abstract class JWM_JobWorkCompleteDALBase : DatabaseConfig
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

        public Boolean Insert(JWM_JobWorkCompleteENT entJobWorkComplete)
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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_Insert";
                        objCmd.Parameters.AddWithValue("@JobWorkCompleteDate", entJobWorkComplete.JobWorkCompleteDate);
                        objCmd.Parameters.AddWithValue("@WorkPartyID", entJobWorkComplete.WorkPartyID);
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveID", entJobWorkComplete.JobWorkReceiveID);
                        objCmd.Parameters.AddWithValue("@QuantityCompleted", entJobWorkComplete.QuantityCompleted);
                        objCmd.Parameters.AddWithValue("@Remarks", entJobWorkComplete.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entJobWorkComplete.UserID);
                        objCmd.Parameters.AddWithValue("@CreationDate", entJobWorkComplete.CreationDate);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entJobWorkComplete.ModifiedDate);

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

        public Boolean Update(JWM_JobWorkCompleteENT entJobWorkComplete)
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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@JobWorkCompleteID", entJobWorkComplete.JobWorkCompleteID);
                        objCmd.Parameters.AddWithValue("@JobWorkCompleteDate", entJobWorkComplete.JobWorkCompleteDate);
                        objCmd.Parameters.AddWithValue("@WorkPartyID", entJobWorkComplete.WorkPartyID);
                        objCmd.Parameters.AddWithValue("@JobWorkReceiveID", entJobWorkComplete.JobWorkReceiveID);
                        objCmd.Parameters.AddWithValue("@QuantityCompleted", entJobWorkComplete.QuantityCompleted);
                        objCmd.Parameters.AddWithValue("@Remarks", entJobWorkComplete.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entJobWorkComplete.UserID);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entJobWorkComplete.ModifiedDate);

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

        public Boolean Delete(SqlInt32 JobWorkCompleteID)
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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_DeleteByPK";
                        objCmd.Parameters.AddWithValue("@JobWorkCompleteID", JobWorkCompleteID);

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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_SelectAll";

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

        public JWM_JobWorkCompleteENT SelectByPK(SqlInt32 JobWorkCompleteID)
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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_SelectByPk";
                        objCmd.Parameters.AddWithValue("@JobWorkCompleteID", JobWorkCompleteID);

                        #endregion Prepare Command

                        #region ReadData and Set Controls

                        JWM_JobWorkCompleteENT entJobWorkComplete = new JWM_JobWorkCompleteENT();

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["JobWorkCompleteID"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.JobWorkCompleteID = Convert.ToInt32(objSDR["JobWorkCompleteID"]);
                                }
                                if (!objSDR["JobWorkCompleteDate"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.JobWorkCompleteDate = Convert.ToDateTime(objSDR["JobWorkCompleteDate"]);
                                }
                                if (!objSDR["WorkPartyID"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.WorkPartyID = Convert.ToInt32(objSDR["WorkPartyID"]);
                                }
                                if (!objSDR["JobWorkReceiveID"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.JobWorkReceiveID = Convert.ToInt32(objSDR["JobWorkReceiveID"]);
                                }
                                if (!objSDR["QuantityCompleted"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.QuantityCompleted = Convert.ToInt32(objSDR["QuantityCompleted"]);
                                }
                                if (!objSDR["Remarks"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.Remarks = Convert.ToString(objSDR["Remarks"]);
                                }
                                if (!objSDR["CreationDate"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.CreationDate = Convert.ToDateTime(objSDR["CreationDate"]);
                                }
                                if (!objSDR["ModifiedDate"].Equals(DBNull.Value))
                                {
                                    entJobWorkComplete.ModifiedDate = Convert.ToDateTime(objSDR["ModifiedDate"]);
                                }
                            }
                        }
                        return entJobWorkComplete;

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

        public DataTable SelectView(SqlInt32 JobWorkCompleteID)
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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_SelectView";
                        objCmd.Parameters.AddWithValue("@JobWorkCompleteID", JobWorkCompleteID);

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
                        objCmd.CommandText = "PR_JWM_JobWorkComplete_SelectByDropDownList";

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