using System.Web;
using System.Web.Mvc;

namespace MVC_AJAXINTRO_JQUERYAJAX2
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}