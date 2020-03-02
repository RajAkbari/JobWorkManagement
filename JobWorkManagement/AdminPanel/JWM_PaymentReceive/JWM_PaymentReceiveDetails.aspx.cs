using JobWorkManagement.BAL;
using System;
using System.Data;

public partial class AdminPanel_JWM_PaymentReceive_JWM_PaymentReceiveDetails : System.Web.UI.Page
{
    #region Page Load

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["PaymentReceiveID"] != null)
            {
                FillControls();
            }
        }
    }

    #endregion Page Load

    #region FillControls

    private void FillControls()
    {
        if (Request.QueryString["PaymentReceiveID"] != null)
        {
            JWM_PaymentReceiveBAL balJWM_PaymentReceive = new JWM_PaymentReceiveBAL();
            DataTable dtJWM_PaymentReceive = balJWM_PaymentReceive.SelectView(Convert.ToInt32(Request.QueryString["PaymentRecediveID"]));
            if (dtJWM_PaymentReceive != null && dtJWM_PaymentReceive.Columns.Count > 0)
            {
                foreach (DataRow dr in dtJWM_PaymentReceive.Rows)
                {
                    if (!dr["PaymentReceiveDate"].Equals(DBNull.Value))
                        lblPaymentReceiveDate.Text = Convert.ToDateTime(dr["PaymentReceiveDate"]).ToString("dd-MM-yyyy");

                    if (!dr["WorkPartyName"].Equals(DBNull.Value))
                        lblWorkPartyName.Text = Convert.ToString(dr["WorkPartyName"]);

                    if (!dr["Amount"].Equals(DBNull.Value))
                        lblAmount.Text = Convert.ToString(dr["Amount"]);
                }
            }
        }
    }

    #endregion FillControls
}