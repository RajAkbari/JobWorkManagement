using JobWorkManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_UserBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_UserBAL:JWM_UserBALBase
    {
        #region SelectByUserNameAndPassword

        public DataTable SelectByUserNameAndPassword(SqlString UserName, SqlString Password)
        {
            JWM_UserDAL dalUser = new JWM_UserDAL();
            return dalUser.SelectByUserNamePassword(UserName, Password);
        }

        #endregion SelectByUserNameAndPassword
    }
}