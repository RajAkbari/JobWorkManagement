using JobWorkManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_WorkReceiveBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_JobWorkReceiveBAL:JWM_JobWorkReceiveBALBase
    {
        #region Search
        public DataTable SelectDuplicate( SqlInt32 WorkPartyID, SqlDateTime StartDate, SqlDateTime EndDate)
        {
           JWM_JobWorkReceiveDAL dalJWM_JobWorkReceive = new JWM_JobWorkReceiveDAL();
            return dalJWM_JobWorkReceive.SelectDuplicate(WorkPartyID, StartDate, EndDate);
        }
        #endregion Search
    }
}