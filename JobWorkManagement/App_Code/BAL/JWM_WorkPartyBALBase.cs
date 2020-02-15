using JobWorkManagement.DAL;
using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_WorkPartyBALBase
/// </summary>
namespace JobWorkManagement.BAL
{
    public abstract class JWM_WorkPartyBALBase
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

        public Boolean Insert(JWM_WorkPartyENT entWorkParty)
        {
            JWM_WorkPartyDAL workPartyDAL = new JWM_WorkPartyDAL();
            if (workPartyDAL.Insert(entWorkParty))
            {
                return true;
            }
            else
            {
                this.Message = workPartyDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(JWM_WorkPartyENT entWorkParty)
        {
            JWM_WorkPartyDAL workPartyDAL = new JWM_WorkPartyDAL();
            if (workPartyDAL.Update(entWorkParty))
            {
                return true;
            }
            else
            {
                this.Message = workPartyDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 WorkPartyID)
        {
            JWM_WorkPartyDAL WorkPartyDAL = new JWM_WorkPartyDAL();
            if (WorkPartyDAL.Delete(WorkPartyID))
            {
                return true;
            }
            else
            {
                this.Message = WorkPartyDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            JWM_WorkPartyDAL dalWorkParty = new JWM_WorkPartyDAL();
            return dalWorkParty.SelectAll();
        }

        public DataTable SelectView(SqlInt32 WorkPartyID)
        {
            JWM_WorkPartyDAL dalJWM_WorkParty = new JWM_WorkPartyDAL();
            return dalJWM_WorkParty.SelectView(WorkPartyID);
        }

        public JWM_WorkPartyENT SelectByPK(SqlInt32 WorkPartyID)
        {
            JWM_WorkPartyDAL dalWorkParty = new JWM_WorkPartyDAL();
            return dalWorkParty.SelectByPK(WorkPartyID);
        }

        public DataTable SelectDropDownList()
        {
            JWM_WorkPartyDAL dalWorkParty = new JWM_WorkPartyDAL();
            return dalWorkParty.SelectDropDownList();
        }

        #endregion Select Operations
    }
}