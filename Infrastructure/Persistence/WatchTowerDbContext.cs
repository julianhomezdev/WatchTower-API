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

}