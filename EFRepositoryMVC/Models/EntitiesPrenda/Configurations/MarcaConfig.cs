using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFRepositoryMVC.Models.EntitiesPrenda.Configurations
{
	public class MarcaConfig : IEntityTypeConfiguration<Marca>
	{
		public void Configure(EntityTypeBuilder<Marca> builder)
		{
			builder.Property(m => m.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode();

		}
	}
}
