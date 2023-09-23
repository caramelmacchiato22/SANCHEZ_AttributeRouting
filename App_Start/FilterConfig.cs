using System.Web;
using System.Web.Mvc;

namespace SANCHEZ_AttributeRouting
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
