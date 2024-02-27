using CodeFirstPatronRepositorio.Data.Entities;

namespace CodeFirstPatronRepositorio.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUser();
        Task<User> GetUserById(int id);
        User CreateUser(User user);
        User UpdateUser(User user);
    }
}
