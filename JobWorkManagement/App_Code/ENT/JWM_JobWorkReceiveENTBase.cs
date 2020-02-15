using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JWM_JobWorkReceiveENTBase
/// </summary>
namespace JobWorkManagement.ENT
{
    public abstract class JWM_JobWorkReceiveENTBase
    {
        #region Properties
        protected SqlInt32 _JobWorkReceiveID;
        public SqlInt32 JobWorkReceiveID
        {
            get
            {
                return _JobWorkReceiveID;
            }
            set
            {
                _JobWorkReceiveID = value;
            }
        }

        protected SqlDateTime _JobWorkReceiveDate;
        public SqlDateTime JobWorkReceiveDate
        {
            get
            {
                return _JobWorkReceiveDate;
            }
            set
            {
                _JobWorkReceiveDate = value;
            }
        }

        protected SqlInt32 _JobTypeID;
        public SqlInt32 JobTypeID
        {
            get
            {
                return _JobTypeID;
            }
            set
            {
                _JobTypeID = value;
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

        protected SqlInt32 _QuantityReceived;
        public SqlInt32 QuantityReceived
        {
            get
            {
                return _QuantityReceived;
            }
            set
            {
                _QuantityReceived = value;
            }
        }

        protected SqlInt32 _QuantityDamaged;
        public SqlInt32 QuantityDamaged
        {
            get
            {
                return _QuantityDamaged;
            }
            set
            {
                _QuantityDamaged = value;
            }
        }

        protected SqlInt32 _QuantityActual;
        public SqlInt32 QuantityActual
        {
            get
            {
                return _QuantityActual;
            }
            set
            {
                _QuantityActual = value;
            }
        }

        protected SqlDateTime _EstimatedDeliveryDate;
        public SqlDateTime EstimatedDeliveryDate
        {
            get
            {
                return _EstimatedDeliveryDate;
            }
            set
            {
                _EstimatedDeliveryDate = value;
            }
        }

        protected SqlDecimal _Rate;
        public SqlDecimal Rate
        {
            get
            {
                return _Rate;
            }
            set
            {
                _Rate = value;
            }
        }

        protected SqlDecimal _TotalAmount;
        public SqlDecimal TotalAmount
        {
            get
            {
                return _TotalAmount;
            }
            set
            {
                _TotalAmount = value;
            }
        }

        protected SqlBoolean _IsActive;
        public SqlBoolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
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