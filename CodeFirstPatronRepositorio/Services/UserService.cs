using CodeFirstPatronRepositorio.Data.Entities;
using CodeFirstPatronRepositorio.Repositories.Interfaces;
using CodeFirstPatronRepositorio.Services.Interfaces;

namespace CodeFirstPatronRepositorio.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _repository;

        public UserService(IGenericRepository<User> repository)
        {
            _repository = repository;
        }
        public User CreateUser(User user)
        {
            _repository.Add(user);
            return user;
        }
        public Task<List<User>> GetAllUser()
        {
            return _repository.GetAllAsync();
        }
        public Task<User> GetUserById(int id)
        {
            return _repository.GetByIdAsync(id);
        }
        public User UpdateUser(User user)
        {
            _repository.Update(user);
            return user;
        }
    }
}
