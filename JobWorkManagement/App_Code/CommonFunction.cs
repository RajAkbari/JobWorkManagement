using System;

/// <summary>
/// Summary description for CommonFunction
/// </summary>
namespace JobWorkManagement
{
    public class CommonFunction
    {
        #region Status IsComplete
        public static string GetStatusLabelCss(bool Status)
        {
            string cssclass = string.Empty;

            if (Convert.ToBoolean(Status))
                cssclass = CSSClass.StatusLabelSuccess;
            else
                cssclass = CSSClass.StatusLabelDanger;

            return cssclass;
        }

        public static string GetStatusLabelCompletePanding(bool Status)
        {
            string txt = string.Empty;

            if (Convert.ToBoolean(Status))
            {
                txt = "Complete";
            }
            else
            {
                txt = "Pending";
            }

            return txt;
        }
        #endregion StatusComplete
    }
}
