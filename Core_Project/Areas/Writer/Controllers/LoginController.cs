﻿using Core_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;

namespace Core_Project.Areas.Writer.Controllers
{
	[AllowAnonymous]
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class LoginController : Controller
	{
		private readonly SignInManager<WriterUser> _signInManager;

		public LoginController(SignInManager<WriterUser> signInManager)
		{
			_signInManager = signInManager;
		}

		public IActionResult Index()
		{

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserLoginViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Profile");
				}
				else
				{
					ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
				}
			}
			return View();
		}

		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Login");
		}
	}
}
