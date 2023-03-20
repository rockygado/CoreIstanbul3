using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoreIstanbul3.Models;

namespace CoreIstanbul3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Instrument> Instrument { get; set; } = default!;
        public DbSet<Facility> Facility { get; set; } = default!;
    }
}