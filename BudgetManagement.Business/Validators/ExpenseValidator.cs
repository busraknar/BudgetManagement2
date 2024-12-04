using BudgetManagement.Entities.Models;
using FluentValidation;

namespace BudgetManagement.Business.Validators
{
    public class ExpenseValidator : AbstractValidator<Expense>
    {
        public ExpenseValidator()
        {
            RuleFor(p => p.Name).NotEmpty()
               .WithMessage("Gider alanı boş geçilemez.");

            RuleFor(p => p.Amount).NotEmpty()
               .WithMessage("Miktar alanı boş geçilemez.");
        }
    }
}
