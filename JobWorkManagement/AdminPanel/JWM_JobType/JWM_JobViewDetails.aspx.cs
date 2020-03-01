using JobWorkManagement.BAL;
using System;
using System.Data;

public partial class AdminPanel_JWM_JobType_JobViewDetails : System.Web.UI.Page
{
    #region Page Load

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["JobTypeID"] != null)
            {
                FillControls();
            }
        }
    }

    #endregion Page Load

    #region FillControls

    private void FillControls()
    {
        if (Request.QueryString["JobTypeID"] != null)
        {
            JWM_JobTypeBAL balJWM_JobType = new JWM_JobTypeBAL();
            DataTable dtJWM_JobType = balJWM_JobType.SelectView(Convert.ToInt32(Request.QueryString["JobTypeID"]));
            if (dtJWM_JobType != null && dtJWM_JobType.Columns.Count > 0)
            {
                foreach (DataRow dr in dtJWM_JobType.Rows)
                {
                    if (!dr["JobTypeName"].Equals(DBNull.Value))
                        lblJobTypeName.Text = Convert.ToString(dr["JobTypeName"]);
                }
            }
        }
    }

    #endregion FillControls
}