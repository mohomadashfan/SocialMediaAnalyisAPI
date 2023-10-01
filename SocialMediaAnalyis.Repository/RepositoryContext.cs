using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialMediaAnalyis.Entities.Models;

namespace SocialMediaAnalyis.Repository
{
    public partial class RepositoryContext : IdentityDbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<SocialMediaUsers>();
            modelBuilder.Entity<Fifa>();
        }

        // public virtual DbSet<SocialMediaUsers> SocialMediaUsers { get; set; }
        public virtual DbSet<Fifa> TwitterFifa { get; set; }
    }
}