using FluentValidation;
using PortfolioApp.DTO.DTOs.SkillDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(s => s.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
