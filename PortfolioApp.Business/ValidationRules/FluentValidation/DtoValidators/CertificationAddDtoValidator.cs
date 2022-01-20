using FluentValidation;
using PortfolioApp.DTO.DTOs.CertificationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
    public class CertificationAddDtoValidator : AbstractValidator<CertificationAddDto>
    {
        public CertificationAddDtoValidator()
        {
            RuleFor(c => c.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
