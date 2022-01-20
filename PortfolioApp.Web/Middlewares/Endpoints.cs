using Microsoft.AspNetCore.Builder;

namespace PortfolioApp.Web.Middlewares
{
    public static class Endpoints
    {
        public static IApplicationBuilder Route(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            return app;
        }
    }
}
