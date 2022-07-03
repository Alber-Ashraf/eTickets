using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.actorId,
                am.movieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am => am.actors_movies).HasForeignKey(m => m.movieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.actor).WithMany(am => am.actors_movies).HasForeignKey(a => a.actorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> actors { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Actor_Movie> actors_movies { get; set; }
        public DbSet<Producer> producers { get; set; }
        public DbSet<Cenima> cenimas { get; set; }
    }
}
