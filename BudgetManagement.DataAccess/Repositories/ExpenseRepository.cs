using BudgetManagement.DataAccess.Context;
using BudgetManagement.Entities.Models;

namespace BudgetManagement.DataAccess.Repositories
{
    public class ExpenseRepository : GenericRepository<Expense>
    {
        public ExpenseRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
