using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_PaymentReceiveENTBase
/// </summary>
namespace JobWorkManagement.ENT
{
    public abstract class JWM_PaymentReceiveENTBase
    {
        #region Properties
        protected SqlInt32 _PaymentReceiveID;
        public SqlInt32 PaymentReceiveID
        {
            get
            {
                return _PaymentReceiveID;
            }
            set
            {
                _PaymentReceiveID = value;
            }
        }

        protected SqlDateTime _PaymentReceiveDate;
        public SqlDateTime PaymentReceiveDate
        {
            get
            {
                return _PaymentReceiveDate;
            }
            set
            {
                _PaymentReceiveDate = value;
            }
        }

        protected SqlInt32 _WorkPartyID;
        public SqlInt32 WorkPartyID
        {
            get
            {
                return _WorkPartyID;
            }
            set
            {
                _WorkPartyID = value;
            }
        }

        protected SqlDecimal _Amount;
        public SqlDecimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                _Amount = value;
            }
        }

        protected SqlInt32 _UserID;
        public SqlInt32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }

        protected SqlString _Remarks;
        public SqlString Remarks
        {
            get
            {
                return _Remarks;
            }
            set
            {
                _Remarks = value;
            }
        }

        protected SqlDateTime _CreationDate;
        public SqlDateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                _CreationDate = value;
            }
        }

        protected SqlDateTime _ModifiedDate;
        public SqlDateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                _ModifiedDate = value;
            }
        }

#endregion Properties
    }
}