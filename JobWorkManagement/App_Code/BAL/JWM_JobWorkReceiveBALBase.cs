using JobWorkManagement.DAL;
using JobWorkManagement.ENT;
using System;
using System.Data;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_JobWorkReceiveBALBase
/// </summary>
namespace JobWorkManagement.BAL
{
    public abstract class JWM_JobWorkReceiveBALBase
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

        public Boolean Insert(JWM_JobWorkReceiveENT entJobWorkReceive)
        {
            JWM_JobWorkReceiveDAL JobWorkReceiveDAL = new JWM_JobWorkReceiveDAL();
            if (JobWorkReceiveDAL.Insert(entJobWorkReceive))
            {
                return true;
            }
            else
            {
                this.Message = JobWorkReceiveDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(JWM_JobWorkReceiveENT entJobWorkReceive)
        {
            JWM_JobWorkReceiveDAL JobWorkReceiveDAL = new JWM_JobWorkReceiveDAL();
            if (JobWorkReceiveDAL.Update(entJobWorkReceive))
            {
                return true;
            }
            else
            {
                this.Message = JobWorkReceiveDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 JobWorkReceiveID)
        {
            JWM_JobWorkReceiveDAL JobWorkReceiveDAL = new JWM_JobWorkReceiveDAL();
            if (JobWorkReceiveDAL.Delete(JobWorkReceiveID))
            {
                return true;
            }
            else
            {
                this.Message = JobWorkReceiveDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            JWM_JobWorkReceiveDAL dalJobWorkReceive = new JWM_JobWorkReceiveDAL();
            return dalJobWorkReceive.SelectAll();
        }

        public JWM_JobWorkReceiveENT SelectByPK(SqlInt32 JobWorkReceiveID)
        {
            JWM_JobWorkReceiveDAL dalJobWorkReceive = new JWM_JobWorkReceiveDAL();
            return dalJobWorkReceive.SelectByPK(JobWorkReceiveID);
        }

        public DataTable SelectView(SqlInt32 JobWorkReceiveID)
        {
            JWM_JobWorkReceiveDAL dalJWM_JobWorkReceive = new JWM_JobWorkReceiveDAL();
            return dalJWM_JobWorkReceive.SelectView(JobWorkReceiveID);
        }

        public DataTable SelectDropDownList(SqlInt32 WorkPartyID)
        {
            JWM_JobWorkReceiveDAL dalJobWorkReceive = new JWM_JobWorkReceiveDAL();
            return dalJobWorkReceive.SelectDropDownList(WorkPartyID);
        }

        #endregion Select Operations
    }
}