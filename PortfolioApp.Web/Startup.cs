using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PortfolioApp.Business.AutoMapper.Profiles;
using PortfolioApp.Business.IOC.Microsoft;
using PortfolioApp.Web.Mapping;
using PortfolioApp.Web.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // document.cookie yazdýðýmýz zaman istenilen cookie bilgilerini verir.
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.Cookie.Name = "PortfolioCookie";
                    options.Cookie.SameSite = SameSiteMode.Strict;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                    options.ExpireTimeSpan = TimeSpan.FromDays(20);
                    options.LoginPath = new PathString("/Auth/Login");
                });

            services.AddCustomDependencies(Configuration);

            //services.AddAutoMapper(typeof(Startup));

            services.AddAutoMapper(typeof(ExperienceProfile),
                                   typeof(MapperProfile),
                                   typeof(Startup));

            services.AddControllersWithViews().AddFluentValidation().AddRazorRuntimeCompilation();
            /* viewlere ihtiyaç duyduðumuz için.
             * AddFluentValidation aracýlýðýyla validasyon kurallarýný yapmýþ olduk
             */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles(); // wwwroot klasörünü dýþarýya açar

            app.UseAuthentication();
            app.UseAuthorization();

            app.Route();
        }
    }
}
