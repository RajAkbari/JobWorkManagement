using JobWorkManagement.ENT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_JobTypeDALBase
/// </summary>
namespace JobWorkManagement.DAL
{
    public abstract class JWM_JobTypeDALBase : DatabaseConfig
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

        public Boolean Insert(JWM_JobTypeENT entJobType)
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
                        objCmd.CommandText = "PR_JWM_JobType_Insert";
                        objCmd.Parameters.AddWithValue("@JobTypeName", entJobType.JobTypeName);
                        objCmd.Parameters.AddWithValue("@Remarks", entJobType.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entJobType.UserID);
                        objCmd.Parameters.AddWithValue("@CreationDate", entJobType.CreationDate);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entJobType.ModifiedDate);

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

        public Boolean Update(JWM_JobTypeENT entJobType)
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
                        objCmd.CommandText = "PR_JWM_JobType_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@JobTypeID", entJobType.JobTypeID);
                        objCmd.Parameters.AddWithValue("@JobTypeName", entJobType.JobTypeName);
                        objCmd.Parameters.AddWithValue("@Remarks", entJobType.Remarks);
                        objCmd.Parameters.AddWithValue("@UserID", entJobType.UserID);
                        objCmd.Parameters.AddWithValue("@ModifiedDate", entJobType.ModifiedDate);

                        //objCmd.Parameters.AddWithValue("@UserID", entJobType.UserID);

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

        public Boolean Delete(SqlInt32 JobTypeID)
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
                        objCmd.CommandText = "PR_JWM_JobType_DeleteByPK";
                        objCmd.Parameters.AddWithValue("@JobTypeID", JobTypeID);

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
                        objCmd.CommandText = "PR_JWM_JobType_SelectAll";

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

        public JWM_JobTypeENT SelectByPK(SqlInt32 JobTypeID)
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
                        objCmd.CommandText = "PR_JWM_JobType_SelectByPk";
                        objCmd.Parameters.AddWithValue("@JobTypeID", JobTypeID);

                        #endregion Prepare Command

                        #region ReadData and Set Controls

                        JWM_JobTypeENT entJobType = new JWM_JobTypeENT();

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["JobTypeID"].Equals(DBNull.Value))
                                {
                                    entJobType.JobTypeID = Convert.ToInt32(objSDR["JobTypeID"]);
                                }
                                if (!objSDR["JobTypeName"].Equals(DBNull.Value))
                                {
                                    entJobType.JobTypeName = Convert.ToString(objSDR["JobTypeName"]);
                                }
                                if (!objSDR["Remarks"].Equals(DBNull.Value))
                                {
                                    entJobType.Remarks = Convert.ToString(objSDR["Remarks"]);
                                }
                                if (!objSDR["CreationDate"].Equals(DBNull.Value))
                                {
                                    entJobType.CreationDate = Convert.ToDateTime(objSDR["CreationDate"]);
                                }
                                if (!objSDR["ModifiedDate"].Equals(DBNull.Value))
                                {
                                    entJobType.ModifiedDate = Convert.ToDateTime(objSDR["ModifiedDate"]);
                                }
                            }
                        }
                        return entJobType;

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

        public DataTable SelectView(SqlInt32 JobTypeID)
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
                        objCmd.CommandText = "PR_JWM_JobType_SelectView";
                        objCmd.Parameters.AddWithValue("@JobTypeID", JobTypeID);

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
                        objCmd.CommandText = "PR_JWM_JobType_SelectByDropDownList";

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