using System;
using DBM.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBM.DAL.Configurations
{
	public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
	{
		public void Configure(EntityTypeBuilder<Photo> builder)
		{
			builder.Property(photo => photo.id)
				.UseIdentityColumn()
				.IsRequired();

			builder.Property(photo => photo.imgUrl)
				.IsRequired();
		}
	}
}

