using System.Web;
using System.Web.Mvc;

namespace MVC_API_MasterDetails
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
