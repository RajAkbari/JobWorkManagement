using JobWorkManagement.BAL;
using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_WorkParty_WorkPartyAddEdit : System.Web.UI.Page
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
            if (Request.QueryString["WorkPartyID"] != null)
            {
                #region Load Data in Edit Mode
                LoadControls(Convert.ToInt32(Request.QueryString["WorkPartyID"]));
                lblPageHeader.Text = "Edit Work Party";
                btnSave.Text = "Update";
                #endregion Load Data in Edit Mode
            }
            else
            {
                lblPageHeader.Text = "Add Work Party";
            }
        }
    }
    #endregion Load Event

    #region LoadControls
    private void LoadControls(SqlInt32 WorkPartyID)
    {
        if (Session["UserID"] != null)
        {
            JWM_WorkPartyENT entWorkParty = new JWM_WorkPartyENT();
            JWM_WorkPartyBAL balWorkParty = new JWM_WorkPartyBAL();

            entWorkParty = balWorkParty.SelectByPK(WorkPartyID);

            if (!entWorkParty.WorkPartyName.IsNull)
                txtWorkPartyName.Text = entWorkParty.WorkPartyName.Value.ToString();

            if (!entWorkParty.Address.IsNull)
                txtAddress.Text = entWorkParty.Address.Value.ToString();

            if (!entWorkParty.Email.IsNull)
                txtEmail.Text = entWorkParty.Email.Value.ToString();

            if (!entWorkParty.MobileNo.IsNull)
                txtMobileNo.Text = entWorkParty.MobileNo.Value.ToString();

            if (!entWorkParty.Remarks.IsNull)
                txtRemarks.Text = entWorkParty.Remarks.Value.ToString();
        }
    }

    #endregion LoadControls

    #region Button : Save
    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtWorkPartyName.Text.Trim() == String.Empty)
            strError += "- Enter Work Party Name<br />";

        if (txtAddress.Text.Trim() == String.Empty)
            strError += "- Enter Address<br />";

        if (txtEmail.Text.Trim() == String.Empty)
            strError += "- Enter Email<br />";

        if (txtMobileNo.Text.Trim() == String.Empty)
            strError += "- Enter Mobile number<br />";

        if (txtRemarks.Text.Trim() == String.Empty)
            strError += "- Enter remarks<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; 
        }

        #endregion Server Side Validation
        if (Session["UserID"] != null)
        {
            JWM_WorkPartyENT entWorkParty = new JWM_WorkPartyENT();
            JWM_WorkPartyBAL balWorkParty = new JWM_WorkPartyBAL();

            #region Gather Data

            if (txtWorkPartyName.Text.Trim() != String.Empty)
                entWorkParty.WorkPartyName = txtWorkPartyName.Text.Trim();

            if (txtAddress.Text.Trim() != String.Empty)
                entWorkParty.Address = txtAddress.Text.Trim();

            if (txtEmail.Text.Trim() != String.Empty)
                entWorkParty.Email = txtEmail.Text.Trim();
            
            if (txtMobileNo.Text.Trim() != String.Empty)
                entWorkParty.MobileNo = txtMobileNo.Text.Trim();

            entWorkParty.UserID = Convert.ToInt32(Session["UserID"]);

            if (txtRemarks.Text.Trim() != String.Empty)
                entWorkParty.Remarks = txtRemarks.Text.Trim();

            entWorkParty.CreationDate = DateTime.Now;

            entWorkParty.ModifiedDate = DateTime.Now;

            if (Request.QueryString["WorkPartyID"] == null)
            {
                balWorkParty.Insert(entWorkParty);
                lblMessage.Text = "Data Inserted Successfully";
                lblMessage.CssClass = "badge badge-success";
                btnSave.Text = "Update";
                ClearControls();
            }
            else
            {
                entWorkParty.WorkPartyID = Convert.ToInt32(Request.QueryString["WorkPartyID"]);

                balWorkParty.Update(entWorkParty);
                lblMessage.Text = "Data Update Successfully";
                lblMessage.CssClass = "badge badge-success";
                Response.Redirect("~/AdminPanel/JWM_WorkParty/JWM_WorkPartyList.aspx");
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
        txtWorkPartyName.Text = "";
        txtAddress.Text = "";
        txtEmail.Text = "";
        txtMobileNo.Text = "";
        txtRemarks.Text = "";

        txtWorkPartyName.Focus();
    }

    #endregion ClearControls
}