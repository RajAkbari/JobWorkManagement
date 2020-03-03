using JobWorkManagement.BAL;
using System;
using System.Data;
using System.Data.SqlTypes;
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
        }
    }

    #endregion Load Event

    #region FillWorkPartyGridView

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

    #endregion FillWorkPartyGridView

    #region Search

    protected void btnShow_Click(object sender, EventArgs e)
    {
        search();
    }

    #endregion Search

    #region FillGridViewOnSearch

    private void search()
    {
        SqlString WorkPartyName = SqlString.Null;

        if (txtWorkParty.Text.Trim() != "")
            WorkPartyName = txtWorkParty.Text.Trim();

        JWM_WorkPartyBAL balWorkParty = new JWM_WorkPartyBAL();
        DataTable dtWorkParty = balWorkParty.Search(WorkPartyName);
        if (dtWorkParty != null && dtWorkParty.Rows.Count > 0)
        {
            gvWorkPartyList.DataSource = dtWorkParty;
            gvWorkPartyList.DataBind();
            lblCount.Text = dtWorkParty.Rows.Count.ToString();
            lblRecord.Visible = false;
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
        txtWorkParty.Text = "";
        search();
    }

    #endregion Button : Clear
}