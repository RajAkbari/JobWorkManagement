using JobWorkManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_WorkPartyBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_WorkPartyBAL:JWM_WorkPartyBALBase
    {
        #region Search
        public DataTable SelectDuplicate(SqlString WorkPartyName)
        {
            JWM_WorkPartyDAL dalJWM_WorkParty = new JWM_WorkPartyDAL();
            return dalJWM_WorkParty.SelectDuplicate(WorkPartyName);
        }
        #endregion Search
    }
}