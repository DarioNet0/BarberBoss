using Microsoft.EntityFrameworkCore;

namespace BarberBoss.Infrastructure.DataAcces
{
    public class BarberBossDbContext : DbContext
    {
        public BarberBossDbContext(DbContextOptions options) : base(options) {}
    }
}
