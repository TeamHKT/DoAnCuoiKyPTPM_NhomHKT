using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<YourEntity> YourEntities { get; set; }
    // Thêm DbSet cho các bảng khác nếu cần
}

