using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_WorkReceiveDAL
/// </summary>
namespace JobWorkManagement.DAL
{
    public class JWM_JobWorkReceiveDAL : JWM_JobWorkReceiveDALBase
    {
        #region Search

        public DataTable Search(SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
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
                        objCmd.CommandText = "PR_JWM_JobWorkReceive_Search";
                        objCmd.Parameters.AddWithValue("@WorkPartyID", WorkPartyID);
                        objCmd.Parameters.AddWithValue("@StartDate", StartDate);
                        objCmd.Parameters.AddWithValue("@EndDate", EndDate);

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

        #endregion Search

        #region Summary

        public DataTable Summary(SqlInt32 JobTypeID, SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
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
                        objCmd.CommandText = "PR_JWM_JobWork_Summary";
                        objCmd.Parameters.AddWithValue("@JobTypeID", JobTypeID);
                        objCmd.Parameters.AddWithValue("@WorkPartyID", WorkPartyID);
                        objCmd.Parameters.AddWithValue("@StartDate", StartDate);
                        objCmd.Parameters.AddWithValue("@EndDate", EndDate);

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

        #endregion Search
    }
}