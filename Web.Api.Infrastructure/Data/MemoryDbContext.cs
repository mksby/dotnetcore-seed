using Microsoft.EntityFrameworkCore;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces.Gateways;

namespace Web.Api.Infrastructure.Data
{
    public class MemoryDbContext : DbContext, IMemoryDbContext
    {
        public MemoryDbContext(DbContextOptions<MemoryDbContext> options)
        : base(options)
        {
        }

        public DbSet<DistrictsCoordinates> DistrictsCoordinates { get; set; }
    }
}
