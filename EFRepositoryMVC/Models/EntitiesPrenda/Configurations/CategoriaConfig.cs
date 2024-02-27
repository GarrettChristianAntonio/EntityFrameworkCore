using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFRepositoryMVC.Models.EntitiesPrenda.Configurations
{
	public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
	{
		public void Configure(EntityTypeBuilder<Categoria> builder)
		{
			builder.Property(c => c.Name)
				.IsRequired()
				.HasMaxLength(50)
				.IsUnicode();
		}
	}
}
