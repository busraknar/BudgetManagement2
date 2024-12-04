using BudgetManagement.DataAccess.Context;
using BudgetManagement.Entities.Models;

namespace BudgetManagement.DataAccess.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
