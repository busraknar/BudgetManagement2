using BudgetManagement.Entities.Abstractions;
using System.Linq.Expressions;

namespace BudgetManagement.Business.Abstractions
{
    public interface IManager<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(int Id);
        IEnumerable<T> GetAll();
        T GetByID(int Id);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
