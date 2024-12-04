using BudgetManagement.Entities.Models;
using FluentValidation;

namespace BudgetManagement.Business.Validators
{
    public class IncomeValidator : AbstractValidator<Income>
    {
        //Ctor yapmayı unutmaaa
        public IncomeValidator()
        {
            //RuleFor(p => p.Name).NotEmpty()
            //    .WithMessage("Gelir alanı boş geçilemez.");

            //RuleFor(p => p.Amount).NotEmpty()
            //   .WithMessage("Miktar alanı boş geçilemez.");
        }

    }
}
