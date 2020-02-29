using JobWorkManagement;
using JobWorkManagement.BAL;
using JobWorkManagement.ENT;
using System;
using System.Data.SqlTypes;
using System.Web.UI;

public partial class AdminPanel_JWM_WorkComplete_WorkCompleteAddEdit : System.Web.UI.Page
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
            FillDropDownList();
            if (Request.QueryString["JobWorkCompleteID"] != null)
            {
                #region Load Data in Edit Mode

                LoadControls(Convert.ToInt32(Request.QueryString["JobWorkCompleteID"]));
                lblPageHeader.Text = "Edit Work Complete";
                btnSave.Text = "Update";

                #endregion Load Data in Edit Mode
            }
            else
            {
                lblPageHeader.Text = "Add Work Complete";
            }
        }
    }

    #endregion Load Event

    #region FillDropDownList

    private void FillDropDownList()
    {
        CommanFillMethods.FillDropDownListWorkPartyID(ddlWorkParty);
    }

    protected void ddlWorkParty_SelectedIndexChanged(object sender, EventArgs e)
    {
        CommanFillMethods.FillDropDownListWorkReceiveID(ddlWorkReceive, Convert.ToInt32(ddlWorkParty.SelectedValue));
    }

    #endregion FillDropDownList

    #region LoadControls

    private void LoadControls(SqlInt32 JobWorkCompleteID)
    {
        if (Session["UserID"] != null)
        {
            JWM_JobWorkCompleteENT entJobWorkComplete = new JWM_JobWorkCompleteENT();
            JWM_JobWorkCompleteBAL balJobWorkComplete = new JWM_JobWorkCompleteBAL();

            entJobWorkComplete = balJobWorkComplete.SelectByPK(JobWorkCompleteID);

            if (!entJobWorkComplete.JobWorkCompleteDate.IsNull)
                txtWorkCompletedDate.Text = entJobWorkComplete.JobWorkCompleteDate.Value.ToString("yyyy-MM-dd");

            if (!entJobWorkComplete.WorkPartyID.IsNull)
                ddlWorkParty.SelectedValue = entJobWorkComplete.WorkPartyID.Value.ToString();

            if (!entJobWorkComplete.JobWorkReceiveID.IsNull)
                ddlWorkReceive.SelectedValue = entJobWorkComplete.JobWorkReceiveID.Value.ToString();

            CommanFillMethods.FillDropDownListWorkReceiveID(ddlWorkReceive, Convert.ToInt32(ddlWorkParty.SelectedValue));

            if (!entJobWorkComplete.QuantityCompleted.IsNull)
                txtQuantityComplete.Text = entJobWorkComplete.QuantityCompleted.Value.ToString();

            if (!entJobWorkComplete.Remarks.IsNull)
                txtRemarks.Text = entJobWorkComplete.Remarks.Value.ToString();
        }
    }

    #endregion LoadControls

    #region Button : Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtWorkCompletedDate.Text.Trim() == String.Empty)
            strError += "- Enter Work Complete date<br />";

        if (ddlWorkParty.SelectedIndex == 0)
            strError += "- Select Work Party<br />";

        if (ddlWorkReceive.SelectedIndex == 0)
            strError += "- Select Work Receive<br />";

        if (txtQuantityComplete.Text.Trim() == String.Empty)
            strError += "- Enter Complete Quantity<br />";

        if (txtRemarks.Text.Trim() == String.Empty)
            strError += "- Enter remarks<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation

        if (Session["UserID"] != null)
        {
            JWM_JobWorkCompleteENT entJobWorkComplete = new JWM_JobWorkCompleteENT();
            JWM_JobWorkCompleteBAL balJobWorkComplete = new JWM_JobWorkCompleteBAL();

            #region Gather Data

            if (txtWorkCompletedDate.Text.Trim() != "")
                entJobWorkComplete.JobWorkCompleteDate = DateTime.Parse(txtWorkCompletedDate.Text.Trim());

            if (ddlWorkParty.SelectedIndex > 0)
                entJobWorkComplete.WorkPartyID = Convert.ToInt32(ddlWorkParty.SelectedValue);

            if (ddlWorkReceive.SelectedIndex > 0)
                entJobWorkComplete.JobWorkReceiveID = Convert.ToInt32(ddlWorkReceive.SelectedValue);

            if (txtQuantityComplete.Text.Trim() != String.Empty)
                entJobWorkComplete.QuantityCompleted = Convert.ToInt32(txtQuantityComplete.Text.Trim());

            entJobWorkComplete.UserID = Convert.ToInt32(Session["UserID"]);

            if (txtRemarks.Text.Trim() != String.Empty)
                entJobWorkComplete.Remarks = txtRemarks.Text.Trim();

            entJobWorkComplete.CreationDate = DateTime.Now;

            entJobWorkComplete.ModifiedDate = DateTime.Now;

            if (Request.QueryString["JobWorkCompleteID"] == null)
            {
                balJobWorkComplete.Insert(entJobWorkComplete);
                lblMessage.Text = "Data Inserted Successfully";
                lblMessage.CssClass = "badge badge-success";
                ClearControls();
            }
            else
            {
                entJobWorkComplete.JobWorkCompleteID = Convert.ToInt32(Request.QueryString["JobWorkCompleteID"]);

                balJobWorkComplete.Update(entJobWorkComplete);
                lblMessage.Text = "Data Update Successfully";
                lblMessage.CssClass = "badge badge-success";
                Response.Redirect("~/AdminPanel/JWM_JobWorkComplete/JWM_JobWorkCompleteList.aspx");
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
    }

    #endregion ClearControls
}