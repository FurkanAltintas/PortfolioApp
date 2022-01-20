using FluentValidation;
using PortfolioApp.DTO.DTOs.InterestDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
     public class InterestAddDtoValidator : AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
