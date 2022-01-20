using FluentValidation;
using PortfolioApp.DTO.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators
{
    public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
    {
        /* AbstractValidator classından kalıtsal yollarla getireceğiz */

        public UserUpdateDtoValidator()
        {
            /*
            
            boş geçilemez
            karakterden büyük olmalıdır
            karakterden küçük olmalıdır
            karakterleri arasında olmalıdır

             */

            RuleFor(u => u.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id boş geçilemez");

            /* Id değeri hiçbir zaman NotEmpty yani bu validasyona düşmez.
             * Çünkü bu bir integer değer. Integer değerin default hali sıfırdır.
             * Bu işlem için InclusiveBetween ve ExclusiveBetween kullanabiliriz.
             */
        }
    }
}
