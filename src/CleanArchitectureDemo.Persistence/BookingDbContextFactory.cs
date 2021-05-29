using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Persistence
{
    public class BookingDbContextFactory : DesignTimeDbContextFactoryBase<BookingDbContext>
    {
        protected override BookingDbContext CreateNewInstance(DbContextOptions<BookingDbContext> options)
        {
            return new BookingDbContext(options);
        }
    }
}
