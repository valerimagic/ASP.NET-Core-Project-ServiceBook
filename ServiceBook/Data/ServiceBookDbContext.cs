namespace ServiceBook.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ServiceBookDbContext : IdentityDbContext
    {
        public ServiceBookDbContext(DbContextOptions<ServiceBookDbContext> options)
            : base(options)
        {
        }
    }
}
