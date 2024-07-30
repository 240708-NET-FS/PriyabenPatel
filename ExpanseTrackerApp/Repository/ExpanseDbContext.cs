using ExpanseTrackerApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ExpanseTrackerApp.Entities;

public class ExpanseDbContext : DbContext
{
    public ExpanseDbContext(DbContextOptions<ExpanseDbContext> options): base(options){}

    public ExpanseDbContext(){}
    public DbSet<Login> Logins{get;set;}
    public DbSet <Expanse> Expanses{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsetting.json")
                                    .Build();
            var ConnectionString = config.GetConnectionString("Defultconection");
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expanse>()
                    .HasOne(e => e.Login)
                    .WithOne(l => l.Expanse)
                    .HasForeignKey<Login>(l => l.UserId);
    }

}