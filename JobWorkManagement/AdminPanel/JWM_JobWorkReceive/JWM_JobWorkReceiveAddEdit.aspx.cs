using JobWorkManagement;
using JobWorkManagement.BAL;
using JobWorkManagement.ENT;
using System;
using System.Data.SqlTypes;
using System.Web.UI;

public partial class AdminPanel_JWM_WorkReceive_WorkReceiveAddEdit : System.Web.UI.Page
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
            if (Request.QueryString["JobWorkReceiveID"] != null)
            {
                #region Load Data in Edit Mode

                LoadControls(Convert.ToInt32(Request.QueryString["JobWorkReceiveID"]));
                lblPageHeader.Text = "Edit Work Receive";
                btnSave.Text = "Update";

                #endregion Load Data in Edit Mode
            }
            else
            {
                lblPageHeader.Text = "Add Work Receive";
            }
        }
    }

    #endregion Load Event

    #region LoadControls

    private void LoadControls(SqlInt32 JobWorkReceiveID)
    {
        if (Session["UserID"] != null)
        {
            JWM_JobWorkReceiveENT entJobWorkReceive = new JWM_JobWorkReceiveENT();
            JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();

            entJobWorkReceive = balJobWorkReceive.SelectByPK(JobWorkReceiveID);

            if (!entJobWorkReceive.JobWorkReceiveDate.IsNull)
                txtWorkReceiveDate.Text = entJobWorkReceive.JobWorkReceiveDate.Value.ToString("yyyy-MM-dd");

            if (!entJobWorkReceive.JobTypeID.IsNull)
                ddlJobType.SelectedValue = entJobWorkReceive.JobTypeID.Value.ToString();

            if (!entJobWorkReceive.WorkPartyID.IsNull)
                ddlWorkParty.SelectedValue = entJobWorkReceive.WorkPartyID.Value.ToString();

            if (!entJobWorkReceive.QuantityReceived.IsNull)
                txtReceiveQuantity.Text = entJobWorkReceive.QuantityReceived.Value.ToString();

            if (!entJobWorkReceive.QuantityDamaged.IsNull)
                txtDamageQuantity.Text = entJobWorkReceive.QuantityDamaged.Value.ToString();

            if (!entJobWorkReceive.QuantityActual.IsNull)
                txtActualQuantity.Text = entJobWorkReceive.QuantityActual.Value.ToString();

            if (!entJobWorkReceive.EstimatedDeliveryDate.IsNull)
                txtEstimatedDate.Text = entJobWorkReceive.EstimatedDeliveryDate.Value.ToString("yyyy-MM-dd");

            if (!entJobWorkReceive.Rate.IsNull)
                txtRate.Text = entJobWorkReceive.Rate.Value.ToString();

            if (!entJobWorkReceive.TotalAmount.IsNull)
                txtTotalAmount.Text = entJobWorkReceive.TotalAmount.Value.ToString();

            if (!entJobWorkReceive.IsActive.IsNull)
                ckbIsActive.Checked = entJobWorkReceive.IsActive.Value;

            if (!entJobWorkReceive.Remarks.IsNull)
                txtRemarks.Text = entJobWorkReceive.Remarks.Value.ToString();
        }
    }

    #endregion LoadControls

    #region Button : Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtWorkReceiveDate.Text.Trim() == String.Empty)
            strError += "- Enter Work Receive Date<br />";

        if (ddlJobType.SelectedIndex == 0)
            strError += "- Select Job type<br />";

        if (ddlWorkParty.SelectedIndex == 0)
            strError += "- Select Work Party<br />";

        if (txtReceiveQuantity.Text.Trim() == String.Empty)
            strError += "- Enter Receive Quantity<br />";

        if (txtDamageQuantity.Text.Trim() == String.Empty)
            strError += "- Enter Damage Quantity<br />";

        if (txtActualQuantity.Text.Trim() == String.Empty)
            strError += "- Enter Actual Quantity<br />";

        if (txtEstimatedDate.Text.Trim() == String.Empty)
            strError += "- Enter Estimated Date<br />";

        if (txtRate.Text.Trim() == String.Empty)
            strError += "- Enter Rate<br />";

        if (txtTotalAmount.Text.Trim() == String.Empty)
            strError += "- Enter Total Amount<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation

        if (Session["UserID"] != null)
        {
            JWM_JobWorkReceiveENT entJobWorkReceive = new JWM_JobWorkReceiveENT();
            JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();

            #region Gather Data

            if (txtWorkReceiveDate.Text.Trim() != "")
                entJobWorkReceive.JobWorkReceiveDate = DateTime.Parse(txtWorkReceiveDate.Text.Trim());

            if (ddlJobType.SelectedIndex > 0)
                entJobWorkReceive.JobTypeID = Convert.ToInt32(ddlJobType.SelectedValue);

            if (ddlWorkParty.SelectedIndex > 0)
                entJobWorkReceive.WorkPartyID = Convert.ToInt32(ddlWorkParty.SelectedValue);

            if (txtReceiveQuantity.Text.Trim() != String.Empty)
                entJobWorkReceive.QuantityReceived = Convert.ToInt32(txtReceiveQuantity.Text.Trim());

            if (txtDamageQuantity.Text.Trim() != String.Empty)
                entJobWorkReceive.QuantityDamaged = Convert.ToInt32(txtDamageQuantity.Text.Trim());

            if (txtActualQuantity.Text.Trim() != String.Empty)
                entJobWorkReceive.QuantityActual = Convert.ToInt32(txtActualQuantity.Text.Trim());

            if (txtEstimatedDate.Text.Trim() != "")
                entJobWorkReceive.EstimatedDeliveryDate = DateTime.Parse(txtEstimatedDate.Text.Trim());

            if (txtRate.Text.Trim() != String.Empty)
                entJobWorkReceive.Rate = Convert.ToDecimal(txtRate.Text.Trim());

            if (txtTotalAmount.Text.Trim() != String.Empty)
                entJobWorkReceive.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text.Trim());

            entJobWorkReceive.IsActive = Convert.ToBoolean(ckbIsActive.Checked);

            entJobWorkReceive.UserID = Convert.ToInt32(Session["UserID"]);

            if (txtRemarks.Text.Trim() != String.Empty)
                entJobWorkReceive.Remarks = txtRemarks.Text.Trim();

            entJobWorkReceive.CreationDate = DateTime.Now;

            entJobWorkReceive.ModifiedDate = DateTime.Now;

            if (Request.QueryString["JobWorkReceiveID"] == null)
            {
                balJobWorkReceive.Insert(entJobWorkReceive);
                lblMessage.Text = "Data Inserted Successfully";
                lblMessage.CssClass = "badge badge-success";
                ClearControls();
            }
            else
            {
                entJobWorkReceive.JobWorkReceiveID = Convert.ToInt32(Request.QueryString["JobWorkReceiveID"]);

                balJobWorkReceive.Update(entJobWorkReceive);
                lblMessage.Text = "Data Update Successfully";
                lblMessage.CssClass = "badge badge-success";
                Response.Redirect("~/AdminPanel/JWM_JobWorkReceive/JWM_JobWorkReceiveList.aspx");
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

    #region FillDropDownList

    private void FillDropDownList()
    {
        CommanFillMethods.FillDropDownListJobTypeID(ddlJobType);
        CommanFillMethods.FillDropDownListWorkPartyID(ddlWorkParty);
    }

    #endregion FillDropDownList

    #region ClearControls

    private void ClearControls()
    {
        ddlJobType.SelectedIndex = -1;
        ddlWorkParty.SelectedIndex = -1;
        txtReceiveQuantity.Text = "";
        txtDamageQuantity.Text = "";
        txtActualQuantity.Text = "";
        txtWorkReceiveDate.Text = "";
        txtEstimatedDate.Text = "";
        txtRate.Text = "";
        txtTotalAmount.Text = "";
        txtRemarks.Text = "";

        ddlJobType.Focus();
    }

    #endregion ClearControls
}