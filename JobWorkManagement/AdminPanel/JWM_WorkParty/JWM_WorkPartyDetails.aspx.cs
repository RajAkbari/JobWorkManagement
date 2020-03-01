using JobWorkManagement.BAL;
using System;
using System.Data;

public partial class AdminPanel_JWM_WorkParty_JWM_WorkPartyDetails : System.Web.UI.Page
{
    #region Page Load

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["WorkPartyID"] != null)
            {
                FillControls();
            }
        }
    }

    #endregion Page Load

    #region FillControls

    private void FillControls()
    {
        if (Request.QueryString["WorkPartyID"] != null)
        {
            JWM_WorkPartyBAL balJWM_WorkParty = new JWM_WorkPartyBAL();
            DataTable dtJWM_WorkParty = balJWM_WorkParty.SelectView(Convert.ToInt32(Request.QueryString["WorkPartyID"]));
            if (dtJWM_WorkParty != null && dtJWM_WorkParty.Columns.Count > 0)
            {
                foreach (DataRow dr in dtJWM_WorkParty.Rows)
                {
                    if (!dr["WorkPartyName"].Equals(DBNull.Value))
                        lblWorkPartyName.Text = Convert.ToString(dr["WorkPartyName"]);

                    if (!dr["Address"].Equals(DBNull.Value))
                        lblAddress.Text = Convert.ToString(dr["Address"]);

                    if (!dr["MobileNo"].Equals(DBNull.Value))
                        lblMobile.Text = Convert.ToString(dr["MobileNo"]);

                    if (!dr["Email"].Equals(DBNull.Value))
                        lblEmail.Text = Convert.ToString(dr["Email"]);
                }
            }
        }
    }

    #endregion FillControls
}