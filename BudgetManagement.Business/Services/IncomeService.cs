using BudgetManagement.Business.Abstractions;
using BudgetManagement.Business.Validators;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Entities.Models;
using FluentValidation.Results;
using System.Linq.Expressions;
using System.Text;

namespace BudgetManagement.Business.Services
{
    public class IncomeService : IManager<Income>
    {
        private readonly IncomeRepository _incomeRepository;
        public IncomeService(IncomeRepository pRepo)
        {
            _incomeRepository = pRepo;
        }


        public void Create(Income entity)
        {
            IncomeValidator pVal = new IncomeValidator();
            ValidationResult result = pVal.Validate(entity);   //Fluent Valdation olanı seç.

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }

            _incomeRepository.Create(entity);
        }

        public void Delete(int Id)
        {
            var income = _incomeRepository.GetByID(Id);

            if (income != null)
            {
                _incomeRepository.Delete(Id);
            }
        }

        public IEnumerable<Income> GetAll()
        {
            return _incomeRepository.GetAll();
        }

        public Income GetByID(int Id)
        {
            return _incomeRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Income, bool>> filter)
        {
            return _incomeRepository.IfEntityExists(filter);
        }

        public void Update(Income entity)
        {
            _incomeRepository.Update(entity);
        }
    }
}
