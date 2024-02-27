using EFRepositoryMVC.DTOs.Prenda;



namespace EFRepositoryMVC.Services.Interfaces
{
    public interface ICategoriaService
    {
        string CreateCategoria(CategoriaCreacionDTO prenda);
        Task<List<CategoriaCreacionDTO>> GetAllCategorias();
    }
}
