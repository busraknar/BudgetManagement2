using BudgetManagement.Business.Abstractions;
using BudgetManagement.Business.Validators;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Entities.Models;
using FluentValidation.Results;
using System.Linq.Expressions;
using System.Text;

namespace BudgetManagement.Business.Services
{
    public class ExpenseService : IManager<Expense>
    {
        private readonly ExpenseRepository _expenseRepository;
        public ExpenseService(ExpenseRepository pRepo)
        {
            _expenseRepository = pRepo;
        }


        public void Create(Expense entity)
        {
            ExpenseValidator pVal = new ExpenseValidator();
            ValidationResult result = pVal.Validate(entity);   //Fluent Valdation olanı seç.

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }

            _expenseRepository.Create(entity);
        }

        public void Delete(int Id)
        {
            var expense = _expenseRepository.GetByID(Id);

            if (expense != null)
            {
                _expenseRepository.Delete(Id);
            }
        }

        public IEnumerable<Expense> GetAll()
        {
            return _expenseRepository.GetAll();
        }

        public Expense GetByID(int Id)
        {
            return _expenseRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Expense, bool>> filter)
        {
            return _expenseRepository.IfEntityExists(filter);
        }

        public void Update(Expense entity)
        {
            _expenseRepository.Update(entity);
        }
    }
}
