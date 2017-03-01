using Microsoft.EntityFrameworkCore;
using FisherInsuranceApi.Models;
namespace FisherInsuranceApi.Data
{
    public class FisherContext : DbContext {
    
    public DbSet<Claim> Claims { get; set; }
    public DbSet<Quote> Quotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
    string connection = "User ID=postgres; Password=Littlee123; Host=localhost;Port=5432; Database=fisher-insurance; Pooling=true;";
        optionsBuilder.UseNpgsql(connection);
    }
}
}