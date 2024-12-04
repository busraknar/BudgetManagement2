using BudgetManagement.Business.Abstractions;
using BudgetManagement.Business.Validators;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Entities.Models;
using FluentValidation.Results;
using System.Linq.Expressions;
using System.Text;

namespace BudgetManagement.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryService(CategoryRepository pRepo)
        {
            _categoryRepository = pRepo;
        }


        public void Create(Category entity)
        {
            CategoryValidator pVal = new CategoryValidator();
            ValidationResult result = pVal.Validate(entity);   //Fluent Valdation olanı seç.

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(r => sb.AppendLine(r.ErrorMessage));
                throw new Exception(sb.ToString());
            }

            _categoryRepository.Create(entity);
        }

        public void Delete(int Id)
        {
            var category = _categoryRepository.GetByID(Id);

            if (category != null)
            {
                _categoryRepository.Delete(Id);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByID(int Id)
        {
            return _categoryRepository.GetByID(Id);
        }

        public bool IfEntityExists(Expression<Func<Category, bool>> filter)
        {
            return _categoryRepository.IfEntityExists(filter);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}
