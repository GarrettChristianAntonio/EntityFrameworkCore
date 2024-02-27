using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFRepositoryMVC.Models.EntitiesPrenda.Configurations
{
	public class ImagenConfig : IEntityTypeConfiguration<Imagen>
	{
		public void Configure(EntityTypeBuilder<Imagen> builder)
		{

			builder.Property(i => i.Name)
				.IsRequired()
				.HasMaxLength(150);

			builder.Property(i => i.Description)
				.IsRequired()
				.HasMaxLength(200);

			builder.Property(i => i.Url)
				.IsRequired()
				.HasMaxLength(1000)
				.IsRequired();
			
			
		}
	}
}
