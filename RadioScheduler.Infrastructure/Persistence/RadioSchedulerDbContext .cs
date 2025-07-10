using Microsoft.EntityFrameworkCore;
using RadioScheduler.Domain.Entities;

namespace RadioScheduler.Infrastructure.Persistence
{
    public class RadioSchedulerDbContext : DbContext
    {
        public RadioSchedulerDbContext(DbContextOptions<RadioSchedulerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Show> Shows { get; set; } = default!;
    }
}