namespace SelfOrder.API.Data;

public class SelfOrderDbContext : DbContext
{
    public SelfOrderDbContext(DbContextOptions<SelfOrderDbContext> options) : base(options)
    {
        
    }

    public DbSet<Food> Foods { get; set; }
}
