using BudgetManagement.Entities.Models;
using FluentValidation;

namespace BudgetManagement.Business.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.Name).NotEmpty()
               .WithMessage("Kategori alanı boş geçilemez.");


        }
    }
}
