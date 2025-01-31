using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LoginBlankTemplate.Models;

namespace LoginBlankTemplate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LoginBlankTemplate.Models.Tickets> Tickets { get; set; } = default!;
        public DbSet<LoginBlankTemplate.Models.Bookings> Bookings { get; set; } = default!;
    }
}
