using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFRepositoryMVC.Models.EntitiesPrenda.Configurations
{
	public class ColorConfig : IEntityTypeConfiguration<Color>
	{
		public void Configure(EntityTypeBuilder<Color> builder)
		{
			builder.Property(co => co.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode();

			builder.Property(co => co.ColorInRGB)
				.IsRequired()
				.IsFixedLength()
				.HasMaxLength(16)
				.IsUnicode();
		}
	}
}
