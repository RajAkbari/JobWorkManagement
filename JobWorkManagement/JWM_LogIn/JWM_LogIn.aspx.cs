using JobWorkManagement.BAL;
using System;
using System.Data;
using System.Drawing;
using System.Web.UI;

public partial class LogIn_LogIn : System.Web.UI.Page
{
    #region Page Load Event

    protected void Page_Load(object sender, EventArgs e)
    {
        txtUserName.Focus();
        if (!Page.IsPostBack)
        {
            Session.Clear();
            this.Page.Title = "Login - Job Work Management";
        }
    }

    #endregion Page Load Event

    #region Login Button Click Event

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        String ErrorMsg = String.Empty;

        #region Validate Controls

        if (txtUserName.Text.Trim() == String.Empty)
            ErrorMsg += "Username is required<br>";

        if (txtPassword.Text.Trim() == String.Empty)
            ErrorMsg += "Password is required";

        if (ErrorMsg != String.Empty)
        {
            lblMessage.Text = ErrorMsg;
            lblMessage.ForeColor = Color.Red;
            return;
        }

        #endregion Validate Controls

        #region Store Data in Session

        JWM_UserBAL balUser = new JWM_UserBAL();
        DataTable dtUserBAL = balUser.SelectByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.ToString());
        if (dtUserBAL != null && dtUserBAL.Rows.Count > 0)
        {
            foreach (DataRow drow in dtUserBAL.Rows)
            {
                if (!drow["UserID"].Equals(System.DBNull.Value))
                    Session["UserID"] = drow["UserID"].ToString();

                if (!drow["UserName"].Equals(System.DBNull.Value))
                    Session["UserName"] = drow["UserName"].ToString();

                //if (!drow["EmailID"].Equals(System.DBNull.Value))
                //    Session["EmailID"] = drow["EmailID"].ToString();

                //if (!drow["ContactNumber"].Equals(DBNull.Value))
                //    Session["ContactNumber"] = drow["ContactNumber"].ToString();
            }
            Response.Redirect("~/AdminPanel/JWM_JobType/JWM_JobTypeList.aspx");
        }
        else
        {
            lblMessage.Text = "Invalid Username or Password";
            lblMessage.ForeColor = System.Drawing.Color.Red;

            txtPassword.Focus();
        }

        #endregion Store Data in Session
    }

    #endregion Login Button Click Event

    //#region Login Button Click Event

    //protected void btnLogin_Click(object sender, EventArgs e)
    //{
    //    #region Server Side Validation

    //    string strErrorMessage = "";
    //    if (txtUserName.Text.Trim() == "")
    //    {
    //        strErrorMessage += "Enter Username <br/>";
    //    }
    //    if (txtPassword.Text.Trim() == "")
    //    {
    //        strErrorMessage += "Enter Password <br/>";
    //    }
    //    if (strErrorMessage != "")
    //    {
    //        lblMessage.Text = strErrorMessage;
    //        return;
    //    }

    //    #endregion Server Side Validation

    //    #region Store Data in Session

    //    SqlConnection objConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AddressBook_3TireConnectionString"].ConnectionString);
    //    SqlCommand objCmd = objConnection.CreateCommand();
    //    objCmd.CommandType = CommandType.StoredProcedure;
    //    objCmd.CommandText = "PR_MasterUser_SelectByUserNameAndPassword";
    //    objCmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
    //    objCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

    //    SqlDataAdapter sda = new SqlDataAdapter(objCmd);
    //    DataTable dt = new DataTable();
    //    sda.Fill(dt);

    //    objConnection.Open();

    //    objConnection.Close();

    //    if (dt.Rows.Count > 0)
    //    {
    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            if (!dr["UserID"].Equals(DBNull.Value))
    //                Session["UserID"] = dr["UserID"].ToString();

    //            if (!dr["UserName"].Equals(DBNull.Value))
    //                Session["UserName"] = dr["UserName"].ToString();

    //            break;
    //        }
    //        Response.Redirect("~/AddressBook/Home");
    //    }
    //    else
    //    {
    //        lblMessage.Text = "Either UserName or Password Is Incorrect";
    //        lblMessage.ForeColor = System.Drawing.Color.Red;
    //        txtUserName.Text = "";
    //        txtPassword.Text = "";
    //        txtUserName.Focus();
    //    }
    //    #endregion Store Data in Session
    //}
    //#endregion Login Button Click Event
}