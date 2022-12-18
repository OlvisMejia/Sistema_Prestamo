using System.Web;
using System.Web.Mvc;

namespace Sistema_De_Prestamos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
