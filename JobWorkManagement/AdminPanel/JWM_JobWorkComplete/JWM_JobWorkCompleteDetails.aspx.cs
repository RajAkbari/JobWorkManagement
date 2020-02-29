using JobWorkManagement.BAL;
using System;
using System.Data;

public partial class AdminPanel_JWM_JobWorkComplete_JWM_JobWorkCompleteDetails : System.Web.UI.Page
{
    #region Page Load

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["JobWorkCompleteID"] != null)
            {
                FillControls();
            }
        }
    }

    #endregion Page Load

    #region FillControls

    private void FillControls()
    {
        if (Request.QueryString["JobWorkCompleteID"] != null)
        {
            JWM_JobWorkCompleteBAL balJWM_JobWorkComplete = new JWM_JobWorkCompleteBAL();
            DataTable dtJWM_JobWorkComplete = balJWM_JobWorkComplete.SelectView(Convert.ToInt32(Request.QueryString["JobWorkCompleteID"]));
            if (dtJWM_JobWorkComplete != null && dtJWM_JobWorkComplete.Columns.Count > 0)
            {
                foreach (DataRow dr in dtJWM_JobWorkComplete.Rows)
                {
                    if (!dr["JobWorkCompleteID"].Equals(DBNull.Value))
                        lblJobWorkCompleteID.Text = Convert.ToString(dr["JobWorkCompleteID"]);

                    if (!dr["JobWorkReceiveID"].Equals(DBNull.Value))
                        lblJobWorkReceive.Text = Convert.ToString(dr["JobWorkReceiveID"]);

                    if (!dr["WorkPartyName"].Equals(DBNull.Value))
                        lblWorkPartyName.Text = Convert.ToString(dr["WorkPartyName"]);

                    if (!dr["JobWorkCompleteDate"].Equals(DBNull.Value))
                        lblWorkCompleteDate.Text = Convert.ToString(dr["JobWorkCompleteDate"]);

                    if (!dr["QuantityCompleted"].Equals(DBNull.Value))
                        lblQuantityComplete.Text = Convert.ToString(dr["QuantityCompleted"]);

                    if (!dr["CreationDate"].Equals(DBNull.Value))
                        lblCreationDate.Text = Convert.ToString(dr["CreationDate"]);

                    if (!dr["ModifiedDate"].Equals(DBNull.Value))
                        lblModifiedDate.Text = Convert.ToString(dr["ModifiedDate"]);
                }
            }
        }
    }

    #endregion FillControls
}