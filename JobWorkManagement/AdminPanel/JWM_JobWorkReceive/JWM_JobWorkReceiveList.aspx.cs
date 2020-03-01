using JobWorkManagement;
using JobWorkManagement.BAL;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_WorkReceive_WorkReceiveList : System.Web.UI.Page
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
            FillJobWorkReceiveGridView();
            FillDropDownList();
        }
    }

    #endregion Load Event

    #region FillJobWorkReceiveGridView

    private void FillJobWorkReceiveGridView()
    {
        if (Session["UserID"] != null)
        {
            JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();
            DataTable dtJobWorkReceive = balJobWorkReceive.SelectAll();
            if (dtJobWorkReceive != null && dtJobWorkReceive.Rows.Count > 0)
            {
                gvJobWorkReceiveList.DataSource = dtJobWorkReceive;
                gvJobWorkReceiveList.DataBind();
                lblCount.Text = dtJobWorkReceive.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillJobWorkReceiveGridView

    #region GvJobWorkReceive_RowCommand

    protected void GvJobWorkReceive_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();
            if (balJobWorkReceive.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillJobWorkReceiveGridView();
            }
            else
            {
                lblMessage.Text = balJobWorkReceive.Message;
            }
        }
    }

    #endregion GvJobWorkReceive_RowCommand

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

        JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();
        DataTable dtJobWorkReceive = balJobWorkReceive.SelectDuplicate(WorkPartyID, StartDate, EndDate);
        if (dtJobWorkReceive != null && dtJobWorkReceive.Rows.Count > 0)
        {
            gvJobWorkReceiveList.DataSource = dtJobWorkReceive;
            gvJobWorkReceiveList.DataBind();
            lblCount.Text = dtJobWorkReceive.Rows.Count.ToString();
            lblRecord.Text = "";
        }
        else
        {
            gvJobWorkReceiveList.DataSource = null;
            gvJobWorkReceiveList.DataBind();
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