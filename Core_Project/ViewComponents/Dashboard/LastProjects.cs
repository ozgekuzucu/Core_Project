using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
	public class LastProjects : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
