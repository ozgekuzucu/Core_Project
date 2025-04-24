using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen Kullanıcı adını girin")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi girin")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
		[Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
		public string ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresini girin")]
		public string Mail { get; set; }
	}
}
