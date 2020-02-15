using JobWorkManagement.DAL;
using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_WorkCompleteBALBase
/// </summary>
namespace JobWorkManagement.BAL
{
    public abstract class JWM_JobWorkCompleteBALBase
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

        #region Insert Operation

        public Boolean Insert(JWM_JobWorkCompleteENT entJobWorkComplete)
        {
            JWM_JobWorkCompleteDAL JobWorkCompleteDAL = new JWM_JobWorkCompleteDAL();
            if (JobWorkCompleteDAL.Insert(entJobWorkComplete))
            {
                return true;
            }
            else
            {
                this.Message = JobWorkCompleteDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(JWM_JobWorkCompleteENT entJobWorkComplete)
        {
            JWM_JobWorkCompleteDAL JobWorkCompleteDAL = new JWM_JobWorkCompleteDAL();
            if (JobWorkCompleteDAL.Update(entJobWorkComplete))
            {
                return true;
            }
            else
            {
                this.Message = JobWorkCompleteDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 JobWorkCompleteID)
        {
            JWM_JobWorkCompleteDAL JobWorkCompleteDAL = new JWM_JobWorkCompleteDAL();
            if (JobWorkCompleteDAL.Delete(JobWorkCompleteID))
            {
                return true;
            }
            else
            {
                this.Message = JobWorkCompleteDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            JWM_JobWorkCompleteDAL dalJobWorkComplete = new JWM_JobWorkCompleteDAL();
            return dalJobWorkComplete.SelectAll();
        }

        public JWM_JobWorkCompleteENT SelectByPK(SqlInt32 JobWorkCompleteID)
        {
            JWM_JobWorkCompleteDAL dalJobWorkComplete = new JWM_JobWorkCompleteDAL();
            return dalJobWorkComplete.SelectByPK(JobWorkCompleteID);
        }

        public DataTable SelectView(SqlInt32 JobWorkCompleteID)
        {
            JWM_JobWorkCompleteDAL dalJWM_JobWorkComplete = new JWM_JobWorkCompleteDAL();
            return dalJWM_JobWorkComplete.SelectView(JobWorkCompleteID);
        }

        #endregion Select Operations
    }
}