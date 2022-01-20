using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Web.Models
{
    public class UserUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyadı alanı boş bırakılamaz")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Email alanı boş bırakılamaz")]
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz")]
        public string Phone { get; set; }
        public string Description { get; set; }

        public IFormFile Picture { get; set; }
    }
}
