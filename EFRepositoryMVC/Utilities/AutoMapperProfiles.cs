using AutoMapper;
using EFRepositoryMVC.DTOs.Prenda;
using EFRepositoryMVC.Models.EntitiesPrenda;

namespace EFRepositoryMVC.Utilities
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles() 
		{
			CreateMap<CategoriaCreacionDTO, Categoria>();
            CreateMap<Categoria, CategoriaCreacionDTO>();
            CreateMap<ColorCreacionDTO, Color>();
			CreateMap<ImagenCreacionDTO, Imagen>();
			CreateMap<MarcaCreacionDTO, Marca>();
			CreateMap<PrendaCreacionDTO, Prenda>();
			CreateMap<PrendaTamanioColorStockCreacionDTO, PrendaTallaColorStock>();
			CreateMap<TamanioCreacionDTO, Talla>();
			
		}
	}
}
