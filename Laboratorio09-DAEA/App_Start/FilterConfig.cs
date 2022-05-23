using System.Web;
using System.Web.Mvc;

namespace Laboratorio09_DAEA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
