using JobWorkManagement.DAL;
using System.Data;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_WorkCompleteBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_JobWorkCompleteBAL : JWM_JobWorkCompleteBALBase
    {
        #region Search

        public DataTable Search(SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
        {
            JWM_JobWorkCompleteDAL dalJWM_JobWorkComplete = new JWM_JobWorkCompleteDAL();
            return dalJWM_JobWorkComplete.Search(WorkPartyID, StartDate, EndDate);
        }

        #endregion Search
    }
}