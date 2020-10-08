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

public partial class AdminPanel_JWM_ItemLeadges_Default : System.Web.UI.Page
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

    //#region FillJobWorkSummaryGridView

    //private void FillJobWorkSummaryGridview()
    //{
    //    if (Session["UserID"] != null)
    //    {
    //        JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();
    //        DataTable dtJobWorkSummary = balJobWorkReceive.SelectAll();
    //        if (dtJobWorkSummary != null && dtJobWorkSummary.Rows.Count > 0)
    //        {
    //            gvJobWorkSummary.DataSource = dtJobWorkSummary;
    //            gvJobWorkSummary.DataBind();
    //            lblCount.Text = dtJobWorkSummary.Rows.Count.ToString();
    //        }
    //        else
    //        {
    //            lblMessage.Text = "No Data Available";
    //        }
    //    }
    //}

    //#endregion FillJobWorkReceiveGridView


    #region FillDropDownList

    private void FillDropDownList()
    {
        CommanFillMethods.FillDropDownListWorkPartyID(ddlWorkParty);
        CommanFillMethods.FillDropDownListJobTypeID(ddlJobType);
    }

    #endregion FillDropDownList

    #region Search
    protected void btnShow_Click(object sender, EventArgs e)
    {
        Summary();
    }

    #endregion Search

    #region FillGridViewOnSearch

    private void Summary()
    {
        SqlInt32 JobTypeID = SqlInt32.Null;
        SqlInt32 WorkPartyID = SqlInt32.Null;
        SqlDateTime StartDate = SqlDateTime.Null;
        SqlDateTime EndDate = SqlDateTime.Null;

        if (ddlWorkParty.SelectedIndex > 0)
            JobTypeID = Convert.ToInt32(ddlJobType.SelectedValue);

        if (ddlWorkParty.SelectedIndex > 0)
            WorkPartyID = Convert.ToInt32(ddlWorkParty.SelectedValue);

        if (txtfromdate.Text.Trim() != "")
            StartDate = DateTime.Parse(txtfromdate.Text.Trim());

        if (txttodate.Text.Trim() != "")
            EndDate = DateTime.Parse(txttodate.Text.Trim());

        JWM_JobWorkReceiveBAL balJobWorkReceive = new JWM_JobWorkReceiveBAL();
        DataTable dtJobWorkSummary = balJobWorkReceive.Summary(JobTypeID, WorkPartyID, StartDate, EndDate);
        if (dtJobWorkSummary != null && dtJobWorkSummary.Rows.Count > 0)
        {
            gvJobWorkSummary.DataSource = dtJobWorkSummary;
            gvJobWorkSummary.DataBind();
            lblCount.Text = dtJobWorkSummary.Rows.Count.ToString();
            lblRecord.Text = "";
        }
        else
        {
            gvJobWorkSummary.DataSource = null;
            gvJobWorkSummary.DataBind();
            lblRecord.Text = "No Record Found";
        }
    }

    #endregion FillGridViewOnSearch

    #region Button : Clear

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ddlJobType.SelectedValue = "-1";
        ddlWorkParty.SelectedValue = "-1";
        txtfromdate.Text = "";
        txttodate.Text = "";
        Summary();
    }

    #endregion Button : Clear
}