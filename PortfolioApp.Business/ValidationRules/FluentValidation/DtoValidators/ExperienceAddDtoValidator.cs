using FluentValidation;
using PortfolioApp.DTO.DTOs.ExperienceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
    public class ExperienceAddDtoValidator : AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddDtoValidator()
        {
            RuleFor(e => e.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(e => e.SubTitle).NotEmpty().WithMessage("Alt başlık alanı boş geçilemez");
            RuleFor(e => e.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(e => e.StartDate).NotEmpty().WithMessage("Başlangıç Tarihi alanı boş geçilemez");
        }
    }
}
