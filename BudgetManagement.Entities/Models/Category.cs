using BudgetManagement.Entities.Abstractions;

namespace BudgetManagement.Entities.Models
{
    public class Category : BaseEntity
    {
        public CategoryType Type { get; set; } // Gelir veya Gider

    }
    public enum CategoryType
    {
        Income = 1,  // Gelir kategorileri için
        Expense = 2  // Gider kategorileri için
    }

}

