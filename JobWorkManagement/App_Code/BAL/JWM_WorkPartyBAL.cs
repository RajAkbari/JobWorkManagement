using JobWorkManagement.DAL;
using System.Data;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_WorkPartyBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_WorkPartyBAL : JWM_WorkPartyBALBase
    {
        #region Search

        public DataTable Search(SqlString WorkPartyName)
        {
            JWM_WorkPartyDAL dalJWM_WorkParty = new JWM_WorkPartyDAL();
            return dalJWM_WorkParty.Search(WorkPartyName);
        }

        #endregion Search

        #region WorkLedge

        public DataTable WorkLedge(SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
        {
            JWM_WorkPartyDAL dalJWM_WorkParty = new JWM_WorkPartyDAL();
            return dalJWM_WorkParty.WorkLedge(WorkPartyID, StartDate, EndDate);
        }

        #endregion WorkLedge
    }
}