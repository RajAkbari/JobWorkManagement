using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DatabaseConfig
/// </summary>
namespace JobWorkManagement
{
    public class DatabaseConfig
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["JobWorkManagementString"].ConnectionString.ToString();
    }
}
