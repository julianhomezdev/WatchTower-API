using Microsoft.EntityFrameworkCore;
using WatchTower_API.Domain;
using Monitor = WatchTower_API.Domain.Monitor;


namespace WatchTower_API.Infrastructure.Persistence;

public class WatchTowerDbContext: DbContext
{

    public WatchTowerDbContext(DbContextOptions<WatchTowerDbContext> options): base(options)
    {
        
        
        
    }


    public DbSet<Monitor> Monitors => Set<Monitor>();

    public DbSet<MonitorCheck> MonitorChecks => Set<MonitorCheck>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            // Convert bool into int 0 or 1
            modelBuilder.Entity<MonitorCheck>()
                .Property(x => x.IsSuccess)
                .HasConversion<int>()
                .HasColumnType("NUMBER(1)");
            modelBuilder.Entity<Monitor>()
                .Property(y => y.IsActive)
                .HasConversion<int>()
                .HasColumnType("NUMBER(1)");



    }
}