using AutoMapper;
using EFRepositoryMVC.Data.Repositories.Interfaces;
using EFRepositoryMVC.DTOs.Prenda;
using EFRepositoryMVC.Models.EntitiesPrenda;
using EFRepositoryMVC.Services.Interfaces;
using System.Collections.Generic;


namespace EFRepositoryMVC.Services
{
    public class CategoriaService : ICategoriaService
    {
       
        
        private readonly IGenericRepository<Categoria> categoriaRepository;
        private readonly IMapper mapper;

        public CategoriaService(IGenericRepository<Categoria> categoriaRepository,IMapper mapper)
        {

     
            this.categoriaRepository = categoriaRepository;
            this.mapper = mapper;
        }

        public string CreateCategoria(CategoriaCreacionDTO categoria)
		{
            try
            {
                categoriaRepository.Add(mapper.Map<Categoria>(categoria));
                return "Creacion Exitosa";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
		}
        public async Task<List<CategoriaCreacionDTO>> GetAllCategorias()
        {
            List<Categoria> categorias = await categoriaRepository.GetAllAsync();
            List<CategoriaCreacionDTO> categoriasDTO = mapper.Map<List<CategoriaCreacionDTO>>(categorias);
            return categoriasDTO;
        }

    }
}
