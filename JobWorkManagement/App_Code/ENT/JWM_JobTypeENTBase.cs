using System.Data.SqlTypes;

/// <summary>
/// Summary description for JobTypeENTBase
/// </summary>
namespace JobWorkManagement.ENT
{
    public abstract class JobTypeENTBase
    {
        #region Properties

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

        protected SqlString _JobTypeName;

        public SqlString JobTypeName
        {
            get
            {
                return _JobTypeName;
            }
            set
            {
                _JobTypeName = value;
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