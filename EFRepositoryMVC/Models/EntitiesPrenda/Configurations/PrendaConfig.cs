using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFRepositoryMVC.Models.EntitiesPrenda.Configurations
{
	public class PrendaConfig : IEntityTypeConfiguration<Prenda>
	{
		public void Configure(EntityTypeBuilder<Prenda> builder)
		{

			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(256);

			builder.Property(p => p.Description)
				.IsRequired()
				.HasMaxLength(3000);

			builder.Property(p => p.Price)				
				.IsRequired()
				.HasColumnType("decimal");

			builder.Property(p => p.Available)
				.HasColumnType("bit")
				.IsRequired();

			builder.Property(p => p.FechaCreacion)
				.HasColumnType("datetime2")
				.IsRequired();

			builder.Property(p => p.FechaActualizacion)
				.HasColumnType("datetime2")
				.IsRequired();
		
		}
	}
}
