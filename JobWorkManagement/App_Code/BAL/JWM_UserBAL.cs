using JobWorkManagement.DAL;
using System.Data;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_UserBAL
/// </summary>
namespace JobWorkManagement.BAL
{
    public class JWM_UserBAL : JWM_UserBALBase
    {
        #region SelectByUserNameAndPassword

        public DataTable SelectByUserNameAndPassword(SqlString UserName, SqlString Password)
        {
            JWM_UserDAL dalUser = new JWM_UserDAL();
            return dalUser.SelectByUserNamePassword(UserName, Password);
        }

        #endregion SelectByUserNameAndPassword

        #region CheckByUserName

        public DataTable CheckUser(SqlString UserName)
        {
            JWM_UserDAL dalUser = new JWM_UserDAL();
            return dalUser.CheckUser(UserName);
        }

        #endregion CheckByUserName
    }
}