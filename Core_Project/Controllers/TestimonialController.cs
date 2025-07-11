﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
	public class TestimonialController : Controller
	{
		TestimonialManager _testimonialManager = new TestimonialManager(new EfTestimonialDal());
		public IActionResult Index()
		{
			var values = _testimonialManager.TGetList();
			return View(values);
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var value = _testimonialManager.TGetByID(id);
			_testimonialManager.TDelete(value);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult AddTestimonial()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddTestimonial(Testimonial p)
		{
			_testimonialManager.TAdd(p);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditTestimonial(int id)
		{
			var values = _testimonialManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditTestimonial(Testimonial testimonial)
		{
			_testimonialManager.TUpdate(testimonial);
			return RedirectToAction("Index");
		}
	}
}
