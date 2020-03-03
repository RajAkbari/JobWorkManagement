using JobWorkManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_PartyLedges_JWM_WorkPartyLedges : System.Web.UI.Page
{
    #region Load Event

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/JWM_LogIn/JWM_Login.aspx");
        }
        if (!Page.IsPostBack)
        {
            FillDropDownList();
        }
    }

    #endregion Load Event

    #region FillDropDownList

    private void FillDropDownList()
    {
        CommanFillMethods.FillDropDownListWorkPartyID(ddlWorkParty);
    }

    #endregion FillDropDownList
}