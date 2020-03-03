using JobWorkManagement.BAL;
using System;
using System.Data;

public partial class AdminPanel_JWM_JobWorkReceive_JWM_WorkReceiveDetails : System.Web.UI.Page
{
    #region Page Load

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["JobWorkReceiveID"] != null)
            {
                FillControls();
            }
        }
    }

    #endregion Page Load

    #region FillControls

    private void FillControls()
    {
        if (Request.QueryString["JobWorkReceiveID"] != null)
        {
            JWM_JobWorkReceiveBAL balJWM_JobWorkReceive = new JWM_JobWorkReceiveBAL();
            DataTable dtJWM_JobWorkReceive = balJWM_JobWorkReceive.SelectView(Convert.ToInt32(Request.QueryString["JobWorkReceiveID"]));
            if (dtJWM_JobWorkReceive != null && dtJWM_JobWorkReceive.Columns.Count > 0)
            {
                foreach (DataRow dr in dtJWM_JobWorkReceive.Rows)
                {
                    if (!dr["JobTypeName"].Equals(DBNull.Value))
                        lblJobTypeName.Text = Convert.ToString(dr["JobTypeName"]);

                    if (!dr["WorkPartyName"].Equals(DBNull.Value))
                        lblWorkPartyName.Text = Convert.ToString(dr["WorkPartyName"]);

                    if (!dr["JobWorkReceiveDate"].Equals(DBNull.Value))
                        lblJobWorkReceiveDate.Text = Convert.ToDateTime(dr["JobWorkReceiveDate"]).ToString("dd-MM-yyyy");

                    if (!dr["QuantityActual"].Equals(DBNull.Value))
                        lblQuantityActual.Text = Convert.ToString(dr["QuantityActual"]);

                    if (!dr["QuantityCompleted"].Equals(DBNull.Value))
                        lblQuantityCompleted.Text = Convert.ToString(dr["QuantityCompleted"]);

                    if (!dr["QuantityPanding"].Equals(DBNull.Value))
                        lblQuantityPanding.Text = Convert.ToString(dr["QuantityPanding"]);

                    if (!dr["EstimatedDeliveryDate"].Equals(DBNull.Value))
                        lblEstimatedDeliveryDate.Text = Convert.ToDateTime(dr["EstimatedDeliveryDate"]).ToString("dd-MM-yyyy");

                    if (!dr["Rate"].Equals(DBNull.Value))
                        lblRate.Text = Convert.ToString(dr["Rate"]);

                    if (!dr["TotalAmount"].Equals(DBNull.Value))
                        lblTotalAmount.Text = Convert.ToString(dr["TotalAmount"]);
                }
            }
        }
    }

    #endregion FillControls
}