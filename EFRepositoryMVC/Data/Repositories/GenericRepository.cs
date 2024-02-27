
using AutoMapper.QueryableExtensions;
using EFRepositoryMVC.Data.DataAccess;
using EFRepositoryMVC.Data.Repositories.Interfaces;
using EFRepositoryMVC.DTOs.Prenda;
using Microsoft.EntityFrameworkCore;

namespace EFRepositoryMVC.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContextCodeFirst _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContextCodeFirst context )
        { 
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

    }

   
}
