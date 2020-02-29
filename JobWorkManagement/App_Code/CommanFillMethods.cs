using JobWorkManagement.BAL;
using System.Data.SqlTypes;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for CommanFillMethods
/// </summary>
namespace JobWorkManagement
{
    public class CommanFillMethods
    {
        #region FillDropDownList

        public static void FillDropDownListJobTypeID(DropDownList ddl)
        {
            JWM_JobTypeBAL balJobType = new JWM_JobTypeBAL();
            ddl.DataSource = balJobType.SelectDropDownList();
            ddl.DataTextField = "JobTypeName";
            ddl.DataValueField = "JobTypeID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("Select Job Type", "-1"));
        }

        public static void FillDropDownListWorkPartyID(DropDownList ddl)
        {
            JWM_WorkPartyBAL balWorkParty = new JWM_WorkPartyBAL();
            ddl.DataSource = balWorkParty.SelectDropDownList();
            ddl.DataTextField = "WorkPartyName";
            ddl.DataValueField = "WorkPartyID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("Select Work Party", "-1"));
        }

        public static void FillDropDownListWorkReceiveID(DropDownList ddl, SqlInt32 WorkPartyID)
        {
            JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();
            ddl.DataSource = balJobWorkReceive.SelectDropDownList(WorkPartyID);
            ddl.DataTextField = "JobWorkReceiveName";
            ddl.DataValueField = "JobWorkReceiveID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("Select Work Receive", "-1"));
        }

        #endregion FillDropDownList
    }
}