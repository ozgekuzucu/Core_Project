﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Project.ViewComponents.Contact
{
	public class SendMessage : ViewComponent
	{
		MessageManager messageManager = new MessageManager(new EfMessageDaL());
		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}
		//[HttpPost]
		//public IViewComponentResult Invoke(Message p)
		//{
		//	p.Date =Convert.ToDateTime(DateTime.Now.ToShortDateString());	
		//	p.Status = true;
		//	messageManager.TAdd(p);
		//	return View();
		//}
	}
}
