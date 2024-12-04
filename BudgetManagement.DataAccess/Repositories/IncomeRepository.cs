using BudgetManagement.DataAccess.Context;
using BudgetManagement.Entities.Models;

namespace BudgetManagement.DataAccess.Repositories
{
    public class IncomeRepository : GenericRepository<Income>
    {
        public IncomeRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
