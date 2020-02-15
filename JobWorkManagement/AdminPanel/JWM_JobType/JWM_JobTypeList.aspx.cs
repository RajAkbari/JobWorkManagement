using JobWorkManagement.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_JWM_JobType_JobTypeList : System.Web.UI.Page
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
            FillJobTypeGridView();
            //FillControls();
        }
    }
    #endregion Load Event

    #region FillGameCategoryGridView
    private void FillJobTypeGridView()
    {
        if (Session["UserID"] != null)
        {

            JWM_JobTypeBAL balJobType = new JWM_JobTypeBAL();
            DataTable dtJobType = balJobType.SelectAll();
            if (dtJobType != null && dtJobType.Rows.Count > 0)
            {
                gvJobTypeList.DataSource = dtJobType;
                gvJobTypeList.DataBind();
                lblCount.Text = dtJobType.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }
    #endregion FillGameCategoryGridView

    #region GvJobType_RowCommand
    protected void GvJobType_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            JWM_JobTypeBAL balJobType = new JWM_JobTypeBAL();
            if (balJobType.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillJobTypeGridView();
            }
            else
            {
                lblMessage.Text = balJobType.Message;
            }
        }
    }
    #endregion GvJobType_RowCommand
}