using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace user_panel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CabinReservation> CabinReservations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
