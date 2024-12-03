using BudgetManagement.Entities.Abstractions;

namespace BudgetManagement.Entities.Models
{
    public class Income : BaseEntity
    {
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
    }
}
