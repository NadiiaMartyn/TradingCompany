using System.Configuration;

namespace DAL
{
    public static class Helper
    {
        public static string CnnVal() => ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
    }
}