using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Common.Interfaces;
using CleanArchitectureDemo.Domain.Common;
using CleanArchitectureDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Persistence
{
    public class BookingDbContext: DbContext, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Event> Events { get; set; }

        public BookingDbContext(DbContextOptions<BookingDbContext> options)
            : base(options)
        {
        }

        public BookingDbContext(
            DbContextOptions<BookingDbContext> options,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
            : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookingDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.CreatedAt = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
