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
                    if (!dr["JobWorkReceiveID"].Equals(DBNull.Value))
                        lblJobWorkReceive.Text = Convert.ToString(dr["JobWorkReceiveID"]);

                    if (!dr["JobTypeName"].Equals(DBNull.Value))
                        lblJobTypeName.Text = Convert.ToString(dr["JobTypeName"]);

                    if (!dr["WorkPartyName"].Equals(DBNull.Value))
                        lblWorkPartyName.Text = Convert.ToString(dr["WorkPartyName"]);

                    if (!dr["QuantityReceived"].Equals(DBNull.Value))
                        lblQuantityReceive.Text = Convert.ToString(dr["QuantityReceived"]);

                    if (!dr["QuantityDamaged"].Equals(DBNull.Value))
                        lblQuantityDamaged.Text = Convert.ToString(dr["QuantityDamaged"]);

                    if (!dr["QuantityActual"].Equals(DBNull.Value))
                        lblQuantityActual.Text = Convert.ToString(dr["QuantityActual"]);

                    if (!dr["EstimatedDeliveryDate"].Equals(DBNull.Value))
                        lblEstimatedDeliveryDate.Text = Convert.ToString(dr["EstimatedDeliveryDate"]);

                    if (!dr["Rate"].Equals(DBNull.Value))
                        lblRate.Text = Convert.ToString(dr["Rate"]);

                    if (!dr["TotalAmount"].Equals(DBNull.Value))
                        lblTotalAmount.Text = Convert.ToString(dr["TotalAmount"]);

                    if (!dr["Remarks"].Equals(DBNull.Value))
                        lblRemarks.Text = Convert.ToString(dr["Remarks"]);

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