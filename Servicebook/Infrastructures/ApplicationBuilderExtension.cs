using Microsoft.EntityFrameworkCore;

namespace ServiceBook.Infrastructures
{
    using ServiceBook.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Builder;
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<ServiceBookDbContext>();

            data.Database.Migrate();

            return app;
        }
    }
}
