using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardScriptPartial : ViewComponent
	{		
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
