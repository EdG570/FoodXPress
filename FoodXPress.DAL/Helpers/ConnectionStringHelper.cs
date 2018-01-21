using System.Configuration;

namespace FoodXPress.DAL.Helpers
{
    public class ConnectionStringHelper
    {
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
