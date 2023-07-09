using System.Web;
using System.Web.Mvc;

namespace AzureCosmosDB_NoSql
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
