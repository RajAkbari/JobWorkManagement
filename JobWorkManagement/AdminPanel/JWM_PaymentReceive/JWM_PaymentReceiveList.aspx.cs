using JobWorkManagement;
using JobWorkManagement.BAL;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_PaymentReceive_PaymentReceiveList : System.Web.UI.Page
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
            FillPaymentReceiveGridView();
            FillDropDownList();
        }
    }

    #endregion Load Event

    #region FillGameCategoryGridView

    private void FillPaymentReceiveGridView()
    {
        if (Session["UserID"] != null)
        {
            JWM_PaymentReceiveBAL balPaymentReceive = new JWM_PaymentReceiveBAL();
            DataTable dtPaymentReceive = balPaymentReceive.SelectAll();
            if (dtPaymentReceive != null && dtPaymentReceive.Rows.Count > 0)
            {
                gvPaymentReceiveList.DataSource = dtPaymentReceive;
                gvPaymentReceiveList.DataBind();
                lblCount.Text = dtPaymentReceive.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillGameCategoryGridView

    #region GvPaymentReceive_RowCommand

    protected void GvPaymentReceive_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            JWM_PaymentReceiveBAL balPaymentReceive = new JWM_PaymentReceiveBAL();
            if (balPaymentReceive.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillPaymentReceiveGridView();
            }
            else
            {
                lblMessage.Text = balPaymentReceive.Message;
            }
        }
    }

    #endregion GvPaymentReceive_RowCommand

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

        JWM_PaymentReceiveBAL balJobWorkReceive = new JWM_PaymentReceiveBAL();
        DataTable dtPaymentReceive = balJobWorkReceive.SelectDuplicate(WorkPartyID, StartDate, EndDate);
        if (dtPaymentReceive != null && dtPaymentReceive.Rows.Count > 0)
        {
            gvPaymentReceiveList.DataSource = dtPaymentReceive;
            gvPaymentReceiveList.DataBind();
            lblCount.Text = dtPaymentReceive.Rows.Count.ToString();
            lblRecord.Text = "";
        }
        else
        {
            gvPaymentReceiveList.DataSource = null;
            gvPaymentReceiveList.DataBind();
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