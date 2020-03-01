using JobWorkManagement;
using JobWorkManagement.BAL;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_WorkComplete_WorkCompleteList : System.Web.UI.Page
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
            FillJobWorkCompleteGridView();
            FillDropDownList();
        }
    }

    #endregion Load Event

    #region FillGameCategoryGridView

    private void FillJobWorkCompleteGridView()
    {
        if (Session["UserID"] != null)
        {
            JWM_JobWorkCompleteBAL balJobWorkComplete = new JWM_JobWorkCompleteBAL();
            DataTable dtJobWorkComplete = balJobWorkComplete.SelectAll();
            if (dtJobWorkComplete != null && dtJobWorkComplete.Rows.Count > 0)
            {
                gvJobWorkCompleteList.DataSource = dtJobWorkComplete;
                gvJobWorkCompleteList.DataBind();
                lblCount.Text = dtJobWorkComplete.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillGameCategoryGridView

    #region GvJobWorkComplete_RowCommand

    protected void GvJobWorkComplete_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            JWM_JobWorkCompleteBAL balJobWorkComplete = new JWM_JobWorkCompleteBAL();
            if (balJobWorkComplete.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillJobWorkCompleteGridView();
            }
            else
            {
                lblMessage.Text = balJobWorkComplete.Message;
            }
        }
    }

    #endregion GvJobWorkComplete_RowCommand

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
        SqlDateTime StartDate = SqlDateTime.Null;
        SqlDateTime EndDate = SqlDateTime.Null;

        if (ddlWorkParty.SelectedIndex > 0)
            WorkPartyID = Convert.ToInt32(ddlWorkParty.SelectedValue);

        if (txtfromdate.Text.Trim() != "")
            StartDate = DateTime.Parse(txtfromdate.Text.Trim());

        if (txttodate.Text.Trim() != "")
            EndDate = DateTime.Parse(txttodate.Text.Trim());

        JWM_JobWorkCompleteBAL balJobWorkComplete = new JWM_JobWorkCompleteBAL();
        DataTable dtJobWorkComplete = balJobWorkComplete.SelectDuplicate(WorkPartyID, StartDate, EndDate);
        if (dtJobWorkComplete != null && dtJobWorkComplete.Rows.Count > 0)
        {
            gvJobWorkCompleteList.DataSource = dtJobWorkComplete;
            gvJobWorkCompleteList.DataBind();
            lblCount.Text = dtJobWorkComplete.Rows.Count.ToString();
            lblRecord.Text = "";
        }
        else
        {
            gvJobWorkCompleteList.DataSource = null;
            gvJobWorkCompleteList.DataBind();
            lblRecord.Text = "No Record Found";
        }
    }

    #endregion FillGridViewOnSearch

    #region Button : Clear

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ddlWorkParty.SelectedValue = "-1";
        txtfromdate.Text = "";
        txttodate.Text = "";
        search();
    }

    #endregion Button : Clear
}