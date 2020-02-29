using JobWorkManagement.DAL;
using JobWorkManagement.ENT;
using System;
using System.Data;
using System.Data.SqlTypes;

namespace JobWorkManagement.BAL
{
    public abstract class JWM_JobTypeBALBase
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

        public Boolean Insert(JWM_JobTypeENT entJobType)
        {
            JWM_JobTypeDAL JobTypeDAL = new JWM_JobTypeDAL();
            if (JobTypeDAL.Insert(entJobType))
            {
                return true;
            }
            else
            {
                this.Message = JobTypeDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(JWM_JobTypeENT entJobType)
        {
            JWM_JobTypeDAL JobTypeDAL = new JWM_JobTypeDAL();
            if (JobTypeDAL.Update(entJobType))
            {
                return true;
            }
            else
            {
                this.Message = JobTypeDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 JobTypeID)
        {
            JWM_JobTypeDAL JobTypeDAL = new JWM_JobTypeDAL();
            if (JobTypeDAL.Delete(JobTypeID))
            {
                return true;
            }
            else
            {
                this.Message = JobTypeDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            JWM_JobTypeDAL dalJobType = new JWM_JobTypeDAL();
            return dalJobType.SelectAll();
        }

        public JWM_JobTypeENT SelectByPK(SqlInt32 JobTypeID)
        {
            JWM_JobTypeDAL dalJobType = new JWM_JobTypeDAL();
            return dalJobType.SelectByPK(JobTypeID);
        }

        public DataTable SelectView(SqlInt32 JobTypeID)
        {
            JWM_JobTypeDAL dalJWM_JobType = new JWM_JobTypeDAL();
            return dalJWM_JobType.SelectView(JobTypeID);
        }

        public DataTable SelectDropDownList()
        {
            JWM_JobTypeDAL dalJobType = new JWM_JobTypeDAL();
            return dalJobType.SelectDropDownList();
        }

        #endregion Select Operations
    }
}