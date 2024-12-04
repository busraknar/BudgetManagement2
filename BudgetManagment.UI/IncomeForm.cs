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

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            // ApplicationDBContext'i oluştur
            using (var context = new ApplicationDBContext())
            {
                // CategoryRepository'ye context'i geç
                var categoryService = new CategoryService(new CategoryRepository(context));

                var categories = categoryService.GetAll();
                cmbIncomeCategory.DataSource = categories;
                cmbIncomeCategory.DisplayMember = "Name";
                cmbIncomeCategory.ValueMember = "Id";
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
    }
}
