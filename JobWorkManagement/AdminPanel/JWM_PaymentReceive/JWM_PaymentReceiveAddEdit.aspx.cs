using JobWorkManagement;
using JobWorkManagement.BAL;
using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_PaymentReceive_PaymentReceiveAddEdit : System.Web.UI.Page
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
            if (Request.QueryString["PaymentReceiveID"] != null)
            {
                #region Load Data in Edit Mode
                LoadControls(Convert.ToInt32(Request.QueryString["PaymentReceiveID"]));
                lblPageHeader.Text = "Edit Payment Receive";
                btnSave.Text = "Update";
                #endregion Load Data in Edit Mode
            }
            else
            {
                lblPageHeader.Text = "Add Payment Receive";
            }
        }
    }
    #endregion Load Event

    #region LoadControls
    private void LoadControls(SqlInt32 PaymentReceiveID)
    {
        if (Session["UserID"] != null)
        {

            JWM_PaymentReceiveENT entPaymentReceive = new JWM_PaymentReceiveENT();
            JWM_PaymentReceiveBAL balPaymentReceive = new JWM_PaymentReceiveBAL();

            entPaymentReceive = balPaymentReceive.SelectByPK(PaymentReceiveID);

            if (!entPaymentReceive.PaymentReceiveDate.IsNull)
                txtPaymentReceiveDate.Text = entPaymentReceive.PaymentReceiveDate.Value.ToString("yyyy-MM-dd");

            if (!entPaymentReceive.WorkPartyID.IsNull)
                ddlWorkParty.SelectedValue = entPaymentReceive.WorkPartyID.Value.ToString();

            if (!entPaymentReceive.Amount.IsNull)
                txtAmount.Text = entPaymentReceive.Amount.Value.ToString();

            if (!entPaymentReceive.Remarks.IsNull)
                txtRemarks.Text = entPaymentReceive.Remarks.Value.ToString();
        }
    }

    #endregion LoadControls

    #region Button : Save
    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtPaymentReceiveDate.Text.Trim() == String.Empty)
            strError += "- Enter Work Receive Date<br />";

        if (ddlWorkParty.SelectedIndex == 0)
            strError += "- Select Work Party<br />";

        if (txtAmount.Text.Trim() == String.Empty)
            strError += "- Enter Amount<br />";

        if (txtRemarks.Text.Trim() == String.Empty)
            strError += "- Enter remarks<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation
        if (Session["UserID"] != null)
        {
            JWM_PaymentReceiveENT entPaymentReceive = new JWM_PaymentReceiveENT();
            JWM_PaymentReceiveBAL balPaymentReceive = new JWM_PaymentReceiveBAL();

            #region Gather Data

            if (txtPaymentReceiveDate.Text.Trim() != "")
                entPaymentReceive.PaymentReceiveDate = DateTime.Parse(txtPaymentReceiveDate.Text.Trim());

            if (ddlWorkParty.SelectedIndex > 0)
                entPaymentReceive.WorkPartyID = Convert.ToInt32(ddlWorkParty.SelectedValue);

            if (txtAmount.Text.Trim() != String.Empty)
                entPaymentReceive.Amount = Convert.ToDecimal(txtAmount.Text.Trim());

            entPaymentReceive.UserID = Convert.ToInt32(Session["UserID"]);

            if (txtRemarks.Text.Trim() != String.Empty)
                entPaymentReceive.Remarks = txtRemarks.Text.Trim();

            entPaymentReceive.CreationDate = DateTime.Now;

            entPaymentReceive.ModifiedDate = DateTime.Now;

            if (Request.QueryString["PaymentReceiveID"] == null)
            {
                balPaymentReceive.Insert(entPaymentReceive);
                lblMessage.Text = "Data Inserted Successfully";
                lblMessage.CssClass = "badge badge-success";
                ClearControls();
            }
            else
            {
                entPaymentReceive.PaymentReceiveID = Convert.ToInt32(Request.QueryString["PaymentReceiveID"]);

                balPaymentReceive.Update(entPaymentReceive);
                lblMessage.Text = "Data Update Successfully";
                lblMessage.CssClass = "badge badge-success";
                Response.Redirect("~/AdminPanel/JWM_PaymentReceive/JWM_PaymentReceiveList.aspx");
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
        CommanFillMethods.FillDropDownListWorkPartyID(ddlWorkParty);
    }

    #endregion FillDropDownList

    #region ClearControls

    private void ClearControls()
    {
        ddlWorkParty.SelectedIndex = -1;
        txtPaymentReceiveDate.Text = "";
        txtAmount.Text = "";
        txtRemarks.Text = "";

        ddlWorkParty.Focus();
    }

    #endregion ClearControls
}