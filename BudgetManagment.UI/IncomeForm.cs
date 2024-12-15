using BudgetManagement.Business.Services;
using BudgetManagement.DataAccess.Context;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Entities.Models;

namespace BudgetManagment.UI
{
    public partial class IncomeForm : Form
    {
        private ApplicationDBContext _context;
        private CategoryService categoryService;

        public IncomeForm()
        {
            InitializeComponent();

            _context = new ApplicationDBContext();

            var categoryRepository = new CategoryRepository(_context);
            categoryService = new CategoryService(categoryRepository);

        }
        private List<Category> GetCategoriesByType(CategoryType type)
        {
            return _context.Categories
                .Where(c => c.Type == type)
                .ToList();
        }
        private void IncomeForm_Load(object sender, EventArgs e)
        {
            // Diğer bir kategori ilk başta gizle
            txtOtherIncomeCategory.Visible = false;
            btnAddIncomeCategory.Visible = false;

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

                    // "Diğer" seçeneği kontrolü için olay bağla
                    cmbIncomeCategory.SelectedIndexChanged += CmbIncomeCategory_SelectedIndexChanged;
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

                // Ayları ComboBox'a ekle
                var months = new List<KeyValuePair<int, string>>
                {
                      new KeyValuePair<int, string>(1, "Ocak"),
                      new KeyValuePair<int, string>(2, "Şubat"),
                      new KeyValuePair<int, string>(3, "Mart"),
                      new KeyValuePair<int, string>(4, "Nisan"),
                      new KeyValuePair<int, string>(5, "Mayıs"),
                      new KeyValuePair<int, string>(6, "Haziran"),
                      new KeyValuePair<int, string>(7, "Temmuz"),
                      new KeyValuePair<int, string>(8, "Ağustos"),
                      new KeyValuePair<int, string>(9, "Eylül"),
                      new KeyValuePair<int, string>(10, "Ekim"),
                      new KeyValuePair<int, string>(11, "Kasım"),
                      new KeyValuePair<int, string>(12, "Aralık"),
                };

                cmbMonth.DataSource = months;
                cmbMonth.DisplayMember = "Value";  // Görünecek kısım (Ay isimleri)
                cmbMonth.ValueMember = "Key";      // Ay numaraları (1-12)
                cmbMonth.SelectedIndex = -1;       // Başlangıçta seçim yapmamak için
            }
        }

        private void LoadIncomeCategories()
        {
            try
            {
                var incomeCategories = GetCategoriesByType(CategoryType.Income);

                // "Diğer" seçeneğini ekle
                incomeCategories.Add(new Category { Id = -1, Name = "Diğer" });

                // ComboBox'u güncelle
                cmbIncomeCategory.DataSource = incomeCategories;
                cmbIncomeCategory.DisplayMember = "Name";
                cmbIncomeCategory.ValueMember = "Id";
                cmbIncomeCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gelir kategorileri yüklenirken hata oluştu: {ex.Message}", "Hata");
            }
        }
        private void CmbIncomeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncomeCategory.SelectedItem is Category selectedCategory && selectedCategory.Name == "Diğer")
            {
                // "Diğer" seçildiğinde TextBox ve Button görünür olsun
                txtOtherIncomeCategory.Visible = true;
                btnAddIncomeCategory.Visible = true;
            }
            else
            {
                // Diğer bir kategori seçildiğinde gizle
                txtOtherIncomeCategory.Visible = false;
                btnAddIncomeCategory.Visible = false;
            }
        }



        private void btnAddIncome_Click(object sender, EventArgs e)
        {

            var incomeRepository = new IncomeRepository(_context);
            var incomeService = new IncomeService(incomeRepository);

            if (cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ay seçiniz!", "Uyarı");
                return;
            }

            // Seçilen ayı al
            int selectedMonth = (int)cmbMonth.SelectedValue;

            // Seçilen aya göre bir tarih oluştur
            DateTime incomeDate = new DateTime(DateTime.Now.Year, selectedMonth, 1); // Ayın ilk günü

            var selectedCategoryId = (int)cmbIncomeCategory.SelectedValue;
            var category = _context.Categories.FirstOrDefault(c => c.Id == selectedCategoryId);

            var income = new Income
            {
                Name = txtIncomeName.Text,
                Category = category.Name,
                Amount = decimal.Parse(txtIncomeAmount.Text),
                Date = incomeDate // Seçilen tarih
            };

            try
            {
                incomeService.Create(income);
                MessageBox.Show("Gelir başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gelir eklenirken hata oluştu: {ex.Message}", "Hata");
            }
        }


        private void btnAddExpense_Click(object sender, EventArgs e)
        {

            var expenseRepository = new ExpenseRepository(_context);
            var expenseService = new ExpenseService(expenseRepository);


            if (cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ay seçiniz!", "Uyarı");
                return;
            }

            // Seçilen ayı al
            int selectedMonth = (int)cmbMonth1.SelectedValue;

            // Seçilen aya göre bir tarih oluştur
            DateTime expenseDate = new DateTime(DateTime.Now.Year, selectedMonth, 1); // Ayın ilk günü

            var selectedCategoryId = (int)cmbExpenseCategory.SelectedValue;
            var category = _context.Categories.FirstOrDefault(c => c.Id == selectedCategoryId);

            var expense = new Expense
            {
                Name = txtExpenseName.Text,
                Category = category.Name,
                Amount = decimal.Parse(txtExpenseAmount.Text),
                Date = expenseDate // Seçilen tarih
            };

            try
            {
                expenseService.Create(expense);
                MessageBox.Show("Gider başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gider eklenirken hata oluştu: {ex.Message}", "Hata");
            }
        }

        private void btnLoadIncome_Click(object sender, EventArgs e)
        {
            // Data sorgusu yapıyoruz.
            IQueryable<Income> incomeQuery = _context.Incomes;

            // Eğer bir ay seçildiyse, sorguyu filtreleyelim 

            if (cmbMonth.SelectedIndex != -1)
            {
                // Seçilen ayı aldık
                int selectedMonth = (int)cmbMonth.SelectedValue;

                // Sorguya ay filtresi ekle
                incomeQuery = incomeQuery.Where(x => x.Date.Month == selectedMonth);
            }

            // Gelirleri listeleyelim
            var incomes = incomeQuery
                .Select(x => new
                {
                    x.Name,
                    x.Amount,
                    x.Date,
                    Category = x.Category
                })
                .ToList();

            // DataGridView'e verileri bağla
            dataGridView1.DataSource = incomes;


            dataGridView1.Columns["Date"].HeaderText = "Tarih";
            dataGridView1.Columns["Name"].HeaderText = "Gelir Adı";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["Category"].HeaderText = "Kategori";

        }

        private void btnLoadExpense_Click(object sender, EventArgs e)
        {

            IQueryable<Expense> expenseQuery = _context.Expenses;


            if (cmbMonth.SelectedIndex != -1)
            {
                // Seçilen ayı al
                int selectedMonth = (int)cmbMonth.SelectedValue;
                expenseQuery = expenseQuery.Where(x => x.Date.Month == selectedMonth);
            }

            // Giderleri listeleyelimm
            var expenses = expenseQuery
                .Select(x => new
                {
                    x.Name,
                    x.Amount,
                    x.Date,
                    Category = x.Category
                })
                .ToList();


            dataGridView1.DataSource = expenses;

            dataGridView1.Columns["Date"].HeaderText = "Tarih";
            dataGridView1.Columns["Name"].HeaderText = "Gider Adı";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["Category"].HeaderText = "Kategori";
        }

        private void btnAddIncomeCategory_Click_1(object sender, EventArgs e)
        {
            string newCategoryName = txtOtherIncomeCategory.Text.Trim();

            if (!string.IsNullOrEmpty(newCategoryName))
            {
                try
                {

                    var newCategory = new Category
                    {
                        Name = newCategoryName,
                        Type = CategoryType.Income // Gelir kategorisi
                    };


                    categoryService.Create(newCategory);

                    // ComboBox'u güncelle ve yeni kategoriyi seç
                    LoadIncomeCategories();
                    cmbIncomeCategory.SelectedValue = newCategory.Id;

                    MessageBox.Show("Yeni kategori başarıyla eklendi.", "Bilgi");

                    // TextBox'u temizle ve gizle
                    txtOtherIncomeCategory.Text = string.Empty;
                    txtOtherIncomeCategory.Visible = false;
                    btnAddIncomeCategory.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Yeni kategori eklenirken bir hata oluştu: {ex.Message}", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.", "Hata");
            }
        }
    }
}
