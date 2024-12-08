using BudgetManagement.Business.Services;
using BudgetManagement.DataAccess.Context;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Entities.Models;

namespace BudgetManagment.UI
{
    public partial class IncomeForm : Form
    {
        private ApplicationDBContext _context;

        public IncomeForm()
        {
            InitializeComponent();

            _context = new ApplicationDBContext();

        }
        private List<Category> GetCategoriesByType(CategoryType type)
        {
            return _context.Categories
                .Where(c => c.Type == type)
                .ToList();
        }
        private void IncomeForm_Load(object sender, EventArgs e)
        {

            // ApplicationDBContext'i oluştur
            using (var context = new ApplicationDBContext())
            {
                // CategoryRepository'ye context'i geç
                var categoryService = new CategoryService(new CategoryRepository(context));
                try
                {
                    var incomeCategory = GetCategoriesByType(CategoryType.Income);
                    cmbIncomeCategory.DataSource = incomeCategory;
                    cmbIncomeCategory.DisplayMember = "Name";
                    cmbIncomeCategory.ValueMember = "Id";
                    cmbIncomeCategory.SelectedIndex = -1;      // Başlangıçta seçim yapmamak için

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gelir kategori seçenekleri yüklenirken bir hata oluştu: {ex.Message}", "Hata");

                }



                try
                {
                    var expenseCategory = GetCategoriesByType(CategoryType.Expense);
                    cmbExpenseCategory.DataSource = expenseCategory;
                    cmbExpenseCategory.DisplayMember = "Name";
                    cmbExpenseCategory.ValueMember = "Id";
                    cmbExpenseCategory.SelectedIndex = -1;      // Başlangıçta seçim yapmamak için

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gider kategori seçenekleri yüklenirken bir hata oluştu: {ex.Message}", "Hata");

                }
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {

            var incomeRepository = new IncomeRepository(_context);
            var incomeService = new IncomeService(incomeRepository);

            var selectedCategoryId = (int)cmbIncomeCategory.SelectedValue;
            var category = _context.Categories.FirstOrDefault(c => c.Id == selectedCategoryId);


            var income = new Income
            {
                Name = txtIncomeName.Text,  // Burada Name alanını formdan alıyoruz
                Category = category.Name,   // Kategoriyi Income nesnesine atıyoruz
                Amount = decimal.Parse(txtIncomeAmount.Text),
                Date = DateTime.Now,

            };

            incomeService.Create(income);
            MessageBox.Show("Gelir başarıyla eklendi!");
        }


        private void btnAddExpense_Click(object sender, EventArgs e)
        {

            var expenseRepository = new ExpenseRepository(_context);
            var expenseService = new ExpenseService(expenseRepository);

            var selectedCategoryId = (int)cmbExpenseCategory.SelectedValue;
            var category = _context.Categories.FirstOrDefault(c => c.Id == selectedCategoryId);


            var expense = new Expense
            {
                Name = txtExpenseName.Text,
                Category = category.Name,
                Amount = decimal.Parse(txtExpenseAmount.Text),
                Date = DateTime.Now,

            };

            expenseService.Create(expense);
            MessageBox.Show("Gider başarıyla eklendi!");
        }
    }
}
