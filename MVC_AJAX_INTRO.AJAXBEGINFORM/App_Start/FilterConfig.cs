using System.Web;
using System.Web.Mvc;

namespace MVC_AJAX_INTRO.AJAXBEGINFORM
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}