using FluentValidation;
using PortfolioApp.DTO.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
    public class UserPasswordDtoValidator : AbstractValidator<UserPasswordDto>
    {
        public UserPasswordDtoValidator()
        {
            RuleFor(u => u.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez");
            RuleFor(u => u.ConfirmPassword).NotEmpty().WithMessage("Parola tekrarı alanı boş geçilemez");
            RuleFor(u => u.Password).Equal(u => u.ConfirmPassword).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
