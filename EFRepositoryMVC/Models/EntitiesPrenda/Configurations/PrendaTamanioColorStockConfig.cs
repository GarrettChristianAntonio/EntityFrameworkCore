using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFRepositoryMVC.Models.EntitiesPrenda.Configurations
{
	public class PrendaTamanioColorStockConfig : IEntityTypeConfiguration<PrendaTallaColorStock>
	{
		public void Configure(EntityTypeBuilder<PrendaTallaColorStock> builder)
		{
			builder.Property(ptcs => ptcs.Stock)
				.IsRequired()
				.HasColumnType("int");
				
			builder.HasKey(ptcs => new { ptcs.PrendaId, ptcs.TallaId, ptcs.ColorId});
		}
	}
}
