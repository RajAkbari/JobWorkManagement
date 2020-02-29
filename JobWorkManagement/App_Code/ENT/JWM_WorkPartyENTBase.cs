using System.Data.SqlTypes;

/// <summary>
/// Summary description for JWM_WorkPartyENTBase
/// </summary>
namespace JobWorkManagement.ENT
{
    public abstract class JWM_WorkPartyENTBase
    {
        #region Properties

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

        protected SqlString _WorkPartyName;

        public SqlString WorkPartyName
        {
            get
            {
                return _WorkPartyName;
            }
            set
            {
                _WorkPartyName = value;
            }
        }

        protected SqlString _Address;

        public SqlString Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }

        protected SqlString _MobileNo;

        public SqlString MobileNo
        {
            get
            {
                return _MobileNo;
            }
            set
            {
                _MobileNo = value;
            }
        }

        protected SqlString _Email;

        public SqlString Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
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