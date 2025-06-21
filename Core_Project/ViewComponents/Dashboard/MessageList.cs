using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project.ViewComponents.Dashboard
{
	public class MessageList:ViewComponent
	{
		MessageManager messageManager = new MessageManager(new EfMessageDaL());

		public IViewComponentResult Invoke()
		{
			var values = messageManager.TGetList().Take(5).ToList();
			return View(values);
		}
	}
}
