﻿using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen adınızı girin")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen soyadınızı girin")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adını girin")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen görsel url girin")]
		public string ImageUrl { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi girin")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
		[Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
		public string ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresini girin")]
		public string Mail { get; set; }
	}
}
