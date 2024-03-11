using Innovt.Data.DataSources;
using Innovt.Data.EFCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using SmartphonesApi.Domain.Smartphone;

namespace SmartphonesApi.Platform.Infrastructure.Database.Context
{
    public class DataContext(IDataSource dataSource) : DBContext(dataSource)
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("Host=localhost; Database=testEf8; Username=postgres; Password=root");

        public DbSet<Smartphone> Smartphones { get; set; }
    }
}
