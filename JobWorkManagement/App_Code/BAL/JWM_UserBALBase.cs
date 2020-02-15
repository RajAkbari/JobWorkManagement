using JobWorkManagement.DAL;
using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_UserBALBase
/// </summary>
namespace JobWorkManagement.BAL
{
    public abstract class JWM_UserBALBase
    {
        #region Local Variables
        protected string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local Variables

        #region InsertOperation

        public Boolean Insert(JWM_UserENT entUser)
        {
            JWM_UserDAL dalUser = new JWM_UserDAL();
            if (dalUser.Insert(entUser))
            {
                return true;
            }
            else
            {
                this.Message = dalUser.Message;
                return false;
            }
        }

        #endregion InsertOperation

        #region UpdateOperation

        public Boolean Update(JWM_UserENT entrUser)
        {
            JWM_UserDAL dalUser = new JWM_UserDAL();
            if (dalUser.Update(entrUser))
            {
                return true;
            }
            else
            {
                this.Message = dalUser.Message;
                return false;
            }
        }

        #endregion UpdateOperation

        #region DeleteOperation

        public Boolean Delete(SqlInt32 UserID)
        {
            JWM_UserDAL dalUser = new JWM_UserDAL();
            if (dalUser.Delete(UserID))
            {
                return true;
            }
            else
            {
                this.Message = dalUser.Message;
                return false;
            }
        }
        #endregion DeleteOperation
    }
}