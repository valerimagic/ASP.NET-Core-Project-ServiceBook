using Microsoft.EntityFrameworkCore;
using ServiceBook.Data.Models;

namespace ServiceBook.Infrastructures
{
    using System.Linq;
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

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(ServiceBookDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }
            
            data.AddRange(new[]
            {
                new Category{Name = "Motor Oil"},
                new Category{Name = "Oil Filter"},
                new Category{Name = "Air Filter"},
            });
        }
    }
}
