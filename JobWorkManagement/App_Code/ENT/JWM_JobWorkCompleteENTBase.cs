using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_JobWorkCompleteENTBase
/// </summary>
namespace JobWorkManagement.ENT
{
    public abstract class JWM_JobWorkCompleteENTBase
    {
        #region Properties

        protected SqlInt32 _JobWorkCompleteID;

        public SqlInt32 JobWorkCompleteID
        {
            get
            {
                return _JobWorkCompleteID;
            }
            set
            {
                _JobWorkCompleteID = value;
            }
        }

        protected SqlDateTime _JobWorkCompleteDate;

        public SqlDateTime JobWorkCompleteDate
        {
            get
            {
                return _JobWorkCompleteDate;
            }
            set
            {
                _JobWorkCompleteDate = value;
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

        protected SqlInt32 _QuantityCompleted;

        public SqlInt32 QuantityCompleted
        {
            get
            {
                return _QuantityCompleted;
            }
            set
            {
                _QuantityCompleted = value;
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