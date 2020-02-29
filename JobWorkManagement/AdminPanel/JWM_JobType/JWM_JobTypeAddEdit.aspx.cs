using JobWorkManagement.BAL;
using JobWorkManagement.ENT;
using System;
using System.Data.SqlTypes;
using System.Web.UI;

public partial class AdminPanel_JWM_JobType_JobTypeAddEdit : System.Web.UI.Page
{
    #region Load Event

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/JWM_LogIn/JWM_Login.aspx");
            }
            if (Request.QueryString["JobTypeID"] != null)
            {
                #region Load Data in Edit Mode

                LoadControls(Convert.ToInt32(Request.QueryString["JobTypeID"]));
                lblPageHeader.Text = "Edit Job Type";
                btnSave.Text = "Update";

                #endregion Load Data in Edit Mode
            }
            else
            {
                lblPageHeader.Text = "Add Job Type";
            }
        }
    }

    #endregion Load Event

    #region LoadControls

    private void LoadControls(SqlInt32 JobTypeID)
    {
        if (Session["UserID"] != null)
        {
            JWM_JobTypeENT entJobType = new JWM_JobTypeENT();
            JWM_JobTypeBAL balJobType = new JWM_JobTypeBAL();

            entJobType = balJobType.SelectByPK(JobTypeID);

            if (!entJobType.JobTypeName.IsNull)
                txtJobTypeName.Text = entJobType.JobTypeName.Value.ToString();

            if (!entJobType.Remarks.IsNull)
                txtRemarks.Text = entJobType.Remarks.Value.ToString();
        }
    }

    #endregion LoadControls

    #region Button : Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtJobTypeName.Text.Trim() == String.Empty)
            strError += "- Enter Job Type Name<br />";

        if (txtRemarks.Text.Trim() == String.Empty)
            strError += "- Enter Job Type Name<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation

        if (Session["UserID"] != null)
        {
            JWM_JobTypeENT entJobType = new JWM_JobTypeENT();
            JWM_JobTypeBAL balJobType = new JWM_JobTypeBAL();

            #region Gather Data

            if (txtJobTypeName.Text.Trim() != String.Empty)
                entJobType.JobTypeName = txtJobTypeName.Text.Trim();

            entJobType.UserID = Convert.ToInt32(Session["UserID"]);

            if (txtRemarks.Text.Trim() != String.Empty)
                entJobType.Remarks = txtRemarks.Text.Trim();

            entJobType.CreationDate = DateTime.Now;

            entJobType.ModifiedDate = DateTime.Now;

            if (Request.QueryString["JobTypeID"] == null)
            {
                balJobType.Insert(entJobType);
                lblMessage.Text = "Data Inserted Successfully";
                lblMessage.CssClass = "badge badge-success";
                ClearControls();
            }
            else
            {
                entJobType.JobTypeID = Convert.ToInt32(Request.QueryString["JobTypeID"]);

                balJobType.Update(entJobType);
                lblMessage.Text = "Data Update Successfully";
                lblMessage.CssClass = "badge badge-success";
                Response.Redirect("~/AdminPanel/JWM_JobType/JWM_JobTypeList.aspx");
            }

            #endregion Gather Data
        }
    }

    #endregion Button : Save

    #region Button : Cancel

    protected void btnCancel_Click(object sender, EventArgs e)
    {
    }

    #endregion Button : Cancel

    #region ClearControls

    private void ClearControls()
    {
        txtJobTypeName.Text = "";
        txtRemarks.Text = "";

        txtJobTypeName.Focus();
    }

    #endregion ClearControls
}