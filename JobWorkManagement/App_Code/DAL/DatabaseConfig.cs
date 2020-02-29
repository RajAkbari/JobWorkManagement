using System.Configuration;

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