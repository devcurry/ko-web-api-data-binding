using System.Web;
using System.Web.Mvc;

namespace MVC40_Editable_DataList
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}