using JobWorkManagement;
using JobWorkManagement.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_WorkParty_WorkPartyList : System.Web.UI.Page
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
            FillWorkPartyGridView();
            FillDropDownList();
        }
    }
    #endregion Load Event

    #region FillGameCategoryGridView

    private void FillWorkPartyGridView()
    {
        if (Session["UserID"] != null)
        {
            JWM_WorkPartyBAL balWorkParty = new JWM_WorkPartyBAL();
            DataTable dtWorkParty = balWorkParty.SelectAll();
            if (dtWorkParty != null && dtWorkParty.Rows.Count > 0)
            {
                gvWorkPartyList.DataSource = dtWorkParty;
                gvWorkPartyList.DataBind();
                lblCount.Text = dtWorkParty.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillGameCategoryGridView

    #region FillDropDownList
    private void FillDropDownList()
    {
        CommanFillMethods.FillDropDownListWorkPartyID(ddlWorkParty);
    }
    #endregion FillDropDownList

    #region Search
    protected void btnShow_Click(object sender, EventArgs e)
    {
        search();
    }
    #endregion Search

    #region FillGridViewOnSearch
    private void search()
    {
        SqlInt32 WorkPartyID = SqlInt32.Null;

        if (ddlWorkParty.SelectedIndex > 0)
            WorkPartyID = Convert.ToInt32(ddlWorkParty.SelectedValue);

        JWM_WorkPartyBAL balWorkParty = new JWM_WorkPartyBAL();
        DataTable dtWorkParty = balWorkParty.SelectDuplicate(WorkPartyID);
        if (dtWorkParty != null && dtWorkParty.Rows.Count > 0)
        {
            gvWorkPartyList.DataSource = dtWorkParty;
            gvWorkPartyList.DataBind();
            lblCount.Text = dtWorkParty.Rows.Count.ToString();
        }
        else
        {
            gvWorkPartyList.DataSource = null;
            gvWorkPartyList.DataBind();
            lblRecord.Text = "No Record Found";
        }

    }
    #endregion FillGridViewOnSearch

    #region GvWorkParty_RowCommand

    protected void GvWorkParty_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            JWM_WorkPartyBAL balWorkParty = new JWM_WorkPartyBAL();
            if (balWorkParty.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillWorkPartyGridView();
            }
            else
            {
                lblMessage.Text = balWorkParty.Message;
            }
        }
    }

    #endregion GvWorkParty_RowCommand

    #region Button : Clear
    protected void btnClear_Click(object sender, EventArgs e)
    {
        ddlWorkParty.SelectedValue = "-1";
    }
    #endregion Button : Clear
}