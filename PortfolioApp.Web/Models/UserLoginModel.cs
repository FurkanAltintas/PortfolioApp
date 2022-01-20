using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Web.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
