using System;
using System.Web.UI;

public partial class Content_AdminPanel : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserID"] == null)
                Response.Redirect("~/JWM_LogIn/JWM_LogIn.aspx");
            if (Session["UserName"] != null)
            {
                lblUserName.Text = "Hi," + Session["UserName"].ToString();
            }
        }
    }

    #region button:logout

    protected void lbtnlogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/JWM_LogIn/JWM_LogIn.aspx");
    }

    #endregion button:logout
}