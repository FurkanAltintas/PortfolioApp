using FluentValidation;
using PortfolioApp.DTO.DTOs.SocialMediaIconDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            RuleFor(s => s.Icon).NotEmpty().WithMessage("Icon alanı boş geçilemez");
            RuleFor(s => s.Link).NotEmpty().WithMessage("Link alanı boş geçilemez");
        }
    }
}
