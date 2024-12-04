using BudgetManagement.DataAccess.Abstractions;
using BudgetManagement.DataAccess.Context;
using BudgetManagement.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BudgetManagement.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDBContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            _dbSet.Remove(GetByID(Id));
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(int Id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == Id) ?? throw new Exception("Bulunamadı");

        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            _dbContext.SaveChanges();
        }
    }
}
