using System;
using DBM.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBM.DAL.Configurations
{
	public class MovieConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
        {
			builder.Property(movie => movie.id)
				.UseIdentityColumn()
				.IsRequired();

			builder.Property(movie => movie.title)
				.HasMaxLength(50)
				.IsRequired();

			builder.Property(movie => movie.description)
				.HasMaxLength(500)
				.IsRequired();

			builder.Property(movie => movie.Date)
				.IsRequired();

			builder.Property(movie => movie.mainPhoto)
				.IsRequired();

			builder.Property(movie => movie.trailerUrl)
				.IsRequired();
        }
	}
}

