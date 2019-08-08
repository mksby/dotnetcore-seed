using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;

namespace Web.Api.Core.Interfaces.Gateways
{
    interface IMemoryDbContext
    {
        DbSet<DistrictsCoordinates> DistrictsCoordinates { get; }
    }
}
