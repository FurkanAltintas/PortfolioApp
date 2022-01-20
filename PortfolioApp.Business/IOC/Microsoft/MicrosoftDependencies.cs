using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PortfolioApp.Business.Concrete;
using PortfolioApp.Business.Interfaces;
using PortfolioApp.Business.Utils;
using PortfolioApp.Business.ValidationRules.FluentValidation.DtoValidators;
using PortfolioApp.DataAccess.Concrete.Dapper;
using PortfolioApp.DataAccess.Interfaces;
using PortfolioApp.DTO.DTOs.CertificationDtos;
using PortfolioApp.DTO.DTOs.EducationDtos;
using PortfolioApp.DTO.DTOs.ExperienceDtos;
using PortfolioApp.DTO.DTOs.InterestDtos;
using PortfolioApp.DTO.DTOs.SkillDtos;
using PortfolioApp.DTO.DTOs.SocialMediaIconDtos;
using PortfolioApp.DTO.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp.Business.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<PortfolioContext>(options => options.UseSqlServer(configuration.GetConnectionString("connectionMsSql")));

            #region Connection
            services.AddTransient<IDbConnection>(connection => new SqlConnection(configuration.GetConnectionString("connectionMsSql")));
            #endregion

            #region Repository
            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IUserRepository, DpUserRepository>();
            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<IExperienceRepository, DpExperienceRepository>();
            services.AddScoped<IExperienceService, ExperienceManager>();

            services.AddScoped<ISocialMediaIconRepository, DpSocialMediaIconRepository>();
            services.AddScoped<ISocialMediaIconService, SocialMediaIconManager>();

            services.AddScoped<ISkillRepository, DpSkillRepository>();
            services.AddScoped<ISkillService, SkillManager>();

            services.AddScoped<ICertificationRepository, DpCertificationRepository>();
            services.AddScoped<ICertificationService, CertificationManager>();

            #endregion

            #region Validator
            services.AddTransient<IValidator<UserUpdateDto>, UserUpdateDtoValidator>();
            services.AddTransient<IValidator<UserPasswordDto>, UserPasswordDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddDtoValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDto>, ExperienceUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestAddDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconAddDto>, SocialMediaIconAddDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconUpdateDto>, SocialMediaIconUpdateDtoValidator>();
            #endregion

            services.AddScoped<IPictureFile, PictureFile>();
            services.AddScoped<IIdentityService, Identity>();
        }
    }
}
