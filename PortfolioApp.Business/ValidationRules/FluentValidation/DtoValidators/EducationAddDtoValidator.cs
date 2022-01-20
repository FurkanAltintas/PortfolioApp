using FluentValidation;
using PortfolioApp.DTO.DTOs.EducationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
    public class EducationAddDtoValidator : AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            RuleFor(e => e.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(e => e.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(e => e.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(e => e.Grade).NotEmpty().WithMessage("Mezuniyet Puanı boş bırakılamaz");
            RuleFor(e => e.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
        }
    }
}
