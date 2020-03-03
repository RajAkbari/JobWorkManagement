using JobWorkManagement.DAL;
using System.Data;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_PaymentReceiveBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_PaymentReceiveBAL : JWM_PaymentReceiveBALBase
    {
        #region Search

        public DataTable Search(SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
        {
            JWM_PaymentReceiveDAL dalJWM_JobPaymentReceive = new JWM_PaymentReceiveDAL();
            return dalJWM_JobPaymentReceive.Search(WorkPartyID, StartDate, EndDate);
        }

        #endregion Search
    }
}