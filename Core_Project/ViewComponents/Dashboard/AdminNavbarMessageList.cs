﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Project.ViewComponents.Dashboard
{
	public class AdminNavbarMessageList : ViewComponent
	{
		WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
		public IViewComponentResult Invoke()
		{
			string p = "admin@gmail.com";
			var values = messageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(3).ToList();
			return View(values);
		}
	}
}
