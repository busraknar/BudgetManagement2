using BudgetManagement.Entities.Abstractions;

namespace BudgetManagement.Entities.Models
{
    public class Expense : BaseEntity
    {
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
    }
}
