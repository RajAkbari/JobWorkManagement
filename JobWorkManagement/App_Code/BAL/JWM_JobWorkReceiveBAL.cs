using JobWorkManagement.DAL;
using System.Data;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_WorkReceiveBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_JobWorkReceiveBAL : JWM_JobWorkReceiveBALBase
    {
        #region Search

        public DataTable Search(SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
        {
            JWM_JobWorkReceiveDAL dalJWM_JobWorkReceive = new JWM_JobWorkReceiveDAL();
            return dalJWM_JobWorkReceive.Search(WorkPartyID, StartDate, EndDate);
        }

        #endregion Search
    }
}