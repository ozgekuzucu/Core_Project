﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Authorize]
	public class DefaultController : Controller
	{
		AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

		public IActionResult Index()
		{
			var valeus = announcementManager.TGetList();
			return View(valeus);
		}

		public IActionResult AnnouncementDetails(int id)
		{
			Announcement announcement = announcementManager.TGetByID(id);
			return View(announcement);
		}
	}
}
