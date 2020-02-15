using JobWorkManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_PaymentReceiveBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_PaymentReceiveBAL:JWM_PaymentReceiveBALBase
    {
        #region Search
        public DataTable SelectDuplicate(SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
        {
            JWM_PaymentReceiveDAL dalJWM_JobPaymentReceive = new JWM_PaymentReceiveDAL();
            return dalJWM_JobPaymentReceive.SelectDuplicate(WorkPartyID, StartDate, EndDate);
        }
        #endregion Search
    }
}