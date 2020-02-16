using JobWorkManagement.BAL;
using JobWorkManagement.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp_SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.Page.Title = "SignUp - Job Work Management";
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtUserName.Text.Trim() == String.Empty)
            strError += "- Enter User Name<br />";

        if (txtDisplayName.Text.Trim() == String.Empty)
            strError += "- Enter Display Name<br />";


        if (txtPassword.Text.Trim() == String.Empty)
            strError += "- Enter Password<br />";

        if (txtEmail.Text.Trim() == String.Empty)
            strError += "- Enter Email<br />";

        if (txtMobileno.Text.Trim() == String.Empty)
            strError += "- Enter Mobile No.<br />";

        if (txtRemarks.Text.Trim() == String.Empty)
            strError += "- Enter Job Type Name<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation

        #region Gather Data
        JWM_UserENT entUser = new JWM_UserENT();
        JWM_UserBAL balUser = new JWM_UserBAL();

        if (txtUserName.Text.Trim() != String.Empty)
            entUser.UserName = txtUserName.Text.Trim();

        if (txtDisplayName.Text.Trim() != String.Empty)
            entUser.DisplayName = txtDisplayName.Text.Trim();

        if (txtPassword.Text.Trim() != String.Empty)
            entUser.Password = txtPassword.Text.Trim();

        if (txtEmail.Text.Trim() != String.Empty)
            entUser.Email = txtEmail.Text.Trim();

        if (txtMobileno.Text.Trim() != String.Empty)
            entUser.MobileNo = txtMobileno.Text.Trim();


        if (txtRemarks.Text.Trim() != String.Empty)
            entUser.Remarks = txtRemarks.Text.Trim();

        entUser.CreationDate = DateTime.Now;

        entUser.ModifiedDate = DateTime.Now;
        #endregion Gather Data

        DataTable dtUserBAL = balUser.CheckUser(txtUserName.Text.Trim());
        if (dtUserBAL != null && dtUserBAL.Rows.Count > 0)
        {
            lblMessage.Text = "User Name " + txtUserName.Text.Trim() + " Is Already Exsist";
            lblMessage.ForeColor = Color.Red;
            txtUserName.Text = "";
            txtDisplayName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtMobileno.Text = "";
            txtRemarks.Text = "";
            txtUserName.Focus();
        }
        else
        {
            balUser.Insert(entUser);
            lblMessage.Text = "Data Inserted Successfully";
            lblMessage.CssClass = "badge badge-success";
            ClearControls();
        }
    }

    #region ClearControls

    private void ClearControls()
    {
        txtUserName.Text = "";
        txtDisplayName.Text = "";
        txtPassword.Text = "";
        txtEmail.Text = "";
        txtMobileno.Text = "";
        txtRemarks.Text = "";
        txtUserName.Focus();
    }

    #endregion ClearControls
}