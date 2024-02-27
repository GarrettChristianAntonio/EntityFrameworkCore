using EFRepositoryMVC.DTOs.Prenda;
using EFRepositoryMVC.Models.EntitiesPrenda;
using EFRepositoryMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EFRepositoryMVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService categoriaService;
		
		public CategoriaController(ICategoriaService categoriaService)
        {
            this.categoriaService = categoriaService;
			
		}
        public IActionResult _Categoria()
        {

            return PartialView();
        }

       


        [HttpPost("Creacion/Categoria")]
        public async Task<IActionResult> addCategoria(CategoriaCreacionDTO categoriaDTO)
        {
            try
            {
                string mensaje = categoriaService.CreateCategoria(categoriaDTO);
                return PartialView("_Categoria");
            }
            catch (Exception ex)
            {
                return PartialView("_Categoria");
            }
        }
        [HttpGet("Mostrar/Categorias")]
        public async Task<IActionResult> GetAllCategorias()
        {
            try
            {
                List<CategoriaCreacionDTO> categorias = await categoriaService.GetAllCategorias();
                return PartialView("_AllCategoria", categorias);
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada, puede devolver un mensaje de error o redirigir a una página de error.
                return PartialView("_AllCategoria", new List<Categoria>()); // Devuelve una lista vacía en caso de error.
            }
        }

        [HttpDelete("Borrar/Categoria")]
        public async Task<IActionResult> DeleteCategoria()
        {

        }
    }
}
