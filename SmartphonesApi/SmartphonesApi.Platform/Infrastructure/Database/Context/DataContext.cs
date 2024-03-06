using Microsoft.EntityFrameworkCore;

namespace SmartphonesApi.Platform.Infrastructure.Database.Context
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Domain.Smartphone.Smartphone> Smartphones { get; set; }
    }
}
