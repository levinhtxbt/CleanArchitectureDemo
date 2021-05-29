using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Room> Rooms { get; set; }

        DbSet<Event> Events { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
