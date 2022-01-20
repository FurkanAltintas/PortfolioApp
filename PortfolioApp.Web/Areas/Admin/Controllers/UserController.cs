using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.Business.Utils;
using PortfolioApp.DTO.DTOs.UserDtos;
using PortfolioApp.Web.Models;

namespace PortfolioApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize] // Giriş yapması gerekiyor
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IPictureFile _pictureFile;
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IPictureFile pictureFile, IIdentityService identityService, IMapper mapper)
        {
            _userService = userService;
            _pictureFile = pictureFile;
            _identityService = identityService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = _userService.FindByName(User.Identity.Name);
            var userUpdateModel = new UserUpdateModel
            {
                Address = user.Address,
                Description = user.Description,
                Email = user.Email,
                FirstName = user.FirstName,
                Id = user.Id,
                ImageUrl = user.ImageUrl,
                LastName = user.LastName,
                Phone = user.Phone
            };

            return View(userUpdateModel);
        }

        [HttpPost]
        public IActionResult Index(UserUpdateModel userUpdateModel)
        {
            var key = _userService.GetById(userUpdateModel.Id);
            if (ModelState.IsValid)
            {
                if (userUpdateModel.Picture != null)
                {
                    _pictureFile.AddFile(userUpdateModel.Picture, out string image);
                    _pictureFile.DeleteFile(key.ImageUrl);
                    key.ImageUrl = image;

                    key.FirstName = userUpdateModel.FirstName;
                    key.LastName = userUpdateModel.LastName;
                    key.Address = userUpdateModel.Address;
                    key.Description = userUpdateModel.Description;
                    key.Email = userUpdateModel.Email;
                    key.Phone = userUpdateModel.Phone;
                    _userService.Update(key);

                    TempData["message"] = "İşleminiz başarıyla gerçekleşmiştir";

                    return RedirectToAction("Index");
                }
            }
            return View(userUpdateModel);
        }

        public IActionResult ChangePassword()
        {
            var user = _identityService.IdentityUser(User.Identity.Name);

            return View(new UserPasswordDto
            {
                Id = user.Id
            });
        }

        [HttpPost]
        public IActionResult ChangePassword(UserPasswordDto userPasswordDto)
        {
            if (ModelState.IsValid)
            {
                var updatedUser = _userService.FindByName(User.Identity.Name);
                updatedUser.Password = userPasswordDto.Password;
                _userService.Update(updatedUser);
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }           
            return View(userPasswordDto);
        }
    }
}
