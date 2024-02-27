using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFRepositoryMVC.Models.EntitiesPrenda.Configurations
{
	public class TamanioConfig : IEntityTypeConfiguration<Talla>
	{
		public void Configure(EntityTypeBuilder<Talla> builder)
		{
			builder.Property(t => t.Name)
				.IsRequired()
				.HasMaxLength(30);
		}
	}
}
