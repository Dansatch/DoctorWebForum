using System.Web;
using System.Web.Mvc;

namespace DoctorWebForum
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Enables use of customised error pages
            filters.Add(new HandleErrorAttribute());

            //Automatically checks if user is logged in before accessing site components
            filters.Add(new AuthorizeAttribute());
        }
    }
}
