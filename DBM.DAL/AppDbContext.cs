using System;
using DBM.DAL.Configurations;
using DBM.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DBM.DAL
{
	public class AppDbContext : IdentityDbContext<User>
	{
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new MovieConfiguration());
            builder.ApplyConfiguration(new PhotoConfiguration());
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}

