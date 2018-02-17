using System.Web;
using System.Web.Mvc;

namespace BSI_24_TALLER_BILLY
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
