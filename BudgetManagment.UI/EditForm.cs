using BudgetManagement.Business.Services;
using BudgetManagement.DataAccess.Context;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Entities.Models;
using System.Data;

namespace BudgetManagment.UI
{
    public partial class EditForm : Form
    {
        private ApplicationDBContext _context;
        private CategoryService categoryService;
        private IncomeService incomeService;
        private ExpenseService expenseService;
        public EditForm()
        {
            InitializeComponent();

            _context = new ApplicationDBContext();

            var categoryRepository = new CategoryRepository(_context);
            categoryService = new CategoryService(categoryRepository);

            var incomeRepository = new IncomeRepository(_context);
            incomeService = new IncomeService(incomeRepository);

            var expenseRepository = new ExpenseRepository(_context);
            expenseService = new ExpenseService(expenseRepository);

            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                var incomeCategories = GetCategoriesByType(CategoryType.Income);
                incomeCategories.Add(new Category { Id = -1, Name = "Diğer" });

                cmbIncomeCategory.DataSource = incomeCategories;
                cmbIncomeCategory.DisplayMember = "Name";
                cmbIncomeCategory.ValueMember = "Id";
                cmbIncomeCategory.SelectedIndex = -1;

                var expenseCategories = GetCategoriesByType(CategoryType.Expense);
                cmbExpenseCategory.DataSource = expenseCategories;
                cmbExpenseCategory.DisplayMember = "Name";
                cmbExpenseCategory.ValueMember = "Id";
                cmbExpenseCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategoriler yüklenirken hata oluştu: {ex.Message}", "Hata");
            }
        }

        private List<Category> GetCategoriesByType(CategoryType type)
        {
            return _context.Categories
                .Where(c => c.Type == type)
                .ToList();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            var selectedCategoryId = (int)cmbIncomeCategory.SelectedValue;
            var category = _context.Categories.FirstOrDefault(c => c.Id == selectedCategoryId);

            var income = new Income
            {
                Name = txtIncomeName.Text,
                Category = category.Name,
                Amount = decimal.Parse(txtIncomeAmount.Text),
                Date = DateTime.Now,
            };

            incomeService.Create(income);
            MessageBox.Show("Gelir başarıyla eklendi!");
        }

        private void btnUpdateIncome_Click(object sender, EventArgs e)
        {
            var selectedIncomeId = (int)dgvIncomes.CurrentRow.Cells["Id"].Value;
            var income = incomeService.GetByID(selectedIncomeId);

            if (income != null)
            {
                income.Name = txtIncomeName.Text;
                income.Amount = decimal.Parse(txtIncomeAmount.Text);

                incomeService.Update(income);
                MessageBox.Show("Gelir bilgisi güncellendi.");
            }
            else
            {
                MessageBox.Show("Seçilen gelir bulunamadı.", "Hata");
            }
        }

        private void btnDeleteIncome_Click(object sender, EventArgs e)
        {
            var selectedIncomeId = (int)dgvIncomes.CurrentRow.Cells["Id"].Value;
            var income = incomeService.GetByID(selectedIncomeId);

            if (income != null)
            {
                incomeService.Delete(selectedIncomeId); // Doğrudan ID ile silme işlemi
                MessageBox.Show("Gelir başarıyla silindi.");
                LoadIncomes(); // Gelirleri tekrar yükle
            }
            else
            {
                MessageBox.Show("Seçilen gelir bulunamadı.", "Hata");
            }

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
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

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            var selectedExpenseId = (int)dgvExpenses.CurrentRow.Cells["Id"].Value;
            var expense = expenseService.GetByID(selectedExpenseId);

            if (expense != null)
            {
                expense.Name = txtExpenseName.Text;
                expense.Amount = decimal.Parse(txtExpenseAmount.Text);

                expenseService.Update(expense);
                MessageBox.Show("Gider bilgisi güncellendi.");
            }
            else
            {
                MessageBox.Show("Seçilen gider bulunamadı.", "Hata");
            }
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            var selectedExpenseId = (int)dgvExpenses.CurrentRow.Cells["Id"].Value;
            var expense = expenseService.GetByID(selectedExpenseId);

            if (expense != null)
            {
                expenseService.Delete(selectedExpenseId); // Doğrudan ID ile silme işlemi
                MessageBox.Show("Gider başarıyla silindi.");
                LoadExpenses(); // Giderleri tekrar yükle
            }
            else
            {
                MessageBox.Show("Seçilen gider bulunamadı.", "Hata");
            }

        }

        private void LoadIncomes()
        {
            var incomes = _context.Incomes.Select(x => new
            {
                x.Id,
                x.Name,
                x.Amount,
                x.Date,
                Category = x.Category // Kategori adı dahil
            }).ToList();

            dgvIncomes.DataSource = incomes;
        }

        private void LoadExpenses()
        {
            var expenses = _context.Expenses.Select(x => new
            {
                x.Id,
                x.Name,
                x.Amount,
                x.Date,
                Category = x.Category // Kategori adı dahil
            }).ToList();

            dgvExpenses.DataSource = expenses;
        }


        private void EditForm_Load(object sender, EventArgs e)
        {
            LoadIncomes();
            LoadExpenses();
        }
    }
}
