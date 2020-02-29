using JobWorkManagement.DAL;
using JobWorkManagement.ENT;
using System;
using System.Data;
using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_PaymentReceiveBALBase
/// </summary>
namespace JobWorkManagement.BAL
{
    public abstract class JWM_PaymentReceiveBALBase
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

        public Boolean Insert(JWM_PaymentReceiveENT entPaymentReceive)
        {
            JWM_PaymentReceiveDAL PaymentReceiveDAL = new JWM_PaymentReceiveDAL();
            if (PaymentReceiveDAL.Insert(entPaymentReceive))
            {
                return true;
            }
            else
            {
                this.Message = PaymentReceiveDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(JWM_PaymentReceiveENT entPaymentReceive)
        {
            JWM_PaymentReceiveDAL PaymentReceiveDAL = new JWM_PaymentReceiveDAL();
            if (PaymentReceiveDAL.Update(entPaymentReceive))
            {
                return true;
            }
            else
            {
                this.Message = PaymentReceiveDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 PaymentReceiveID)
        {
            JWM_PaymentReceiveDAL PaymentReceiveDAL = new JWM_PaymentReceiveDAL();
            if (PaymentReceiveDAL.Delete(PaymentReceiveID))
            {
                return true;
            }
            else
            {
                this.Message = PaymentReceiveDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            JWM_PaymentReceiveDAL dalPaymentReceive = new JWM_PaymentReceiveDAL();
            return dalPaymentReceive.SelectAll();
        }

        public JWM_PaymentReceiveENT SelectByPK(SqlInt32 PaymentReceiveID)
        {
            JWM_PaymentReceiveDAL dalPaymentReceive = new JWM_PaymentReceiveDAL();
            return dalPaymentReceive.SelectByPK(PaymentReceiveID);
        }

        public DataTable SelectView(SqlInt32 PaymentReceiveID)
        {
            JWM_PaymentReceiveDAL dalJWM_PaymentReceive = new JWM_PaymentReceiveDAL();
            return dalJWM_PaymentReceive.SelectView(PaymentReceiveID);
        }

        #endregion Select Operations
    }
}