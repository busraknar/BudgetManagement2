using BudgetManagement.Business.Abstractions;
using BudgetManagement.Business.Services;
using BudgetManagement.DataAccess.Context;
using BudgetManagement.DataAccess.Repositories;
using BudgetManagement.Entities.Models;

namespace BudgetManagment.UI
{
    public partial class Rapor : Form
    {

        private ApplicationDBContext _context;
        private readonly IManager<Category> categoryService;
        private readonly IncomeRepository _incomeRepository;
        private readonly ExpenseRepository _expenseRepository;


        public Rapor()
        {
            InitializeComponent();
            _context = new ApplicationDBContext();

            var categoryRepository = new CategoryRepository(_context);
            categoryService = new CategoryService(categoryRepository);
            LoadMonths();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void LoadMonths()
        {
            panelMonth.Size = new Size(600, 300);
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
                        new KeyValuePair<int, string>(12, "Aralık")
                  };
            int columns = 3; // 3 buton yan yana olacak
            int row = 0;
            int column = 0;

            foreach (var month in months)
            {
                Button btnMonth = new Button
                {
                    Text = month.Value,
                    Tag = month.Key,
                    Width = 100,
                    Height = 50,
                    Margin = new Padding(5),
                    BackColor = Color.LightBlue
                };

                btnMonth.Click += MonthButton_Click;
                panelMonth.Controls.Add(btnMonth);
                column++;
                if (column >= columns) // 3 butondan sonra alt satıra geç
                {
                    column = 0;
                    row++;
                    btnMonth.Dock = DockStyle.Top;
                }
            }

            // Yatay veya dikey düzenleme için Panel özelliklerini ayarlama
            //panelMonth.AutoSize = true;  // Panel'i genişletmek için AutoSize özelliği
            //panelMonth.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }



        private void MonthButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            int month = (int)button.Tag; // Tıklanan ayın numarasını al

            // Gelir verilerini getir
            var incomes = _context.Incomes
                .Where(i => i.Date.Month == month)
                .Select(i => new
                {
                    i.Name,
                    i.Amount,
                    i.Date,
                    Category = i.Category // Kategori adı (örneğin, ilişkili bir tablo varsa)
                })
                .ToList();

            // Gider verilerini getir
            var expenses = _context.Expenses
                .Where(e => e.Date.Month == month)
                .Select(e => new
                {
                    e.Name,
                    e.Amount,
                    e.Date,
                    Category = e.Category
                })
                .ToList();

            // Gelir verilerini gelir DataGridView'e bağla
            dgvIncome.DataSource = incomes;

            // Gider verilerini gider DataGridView'e bağla
            dgvExpense.DataSource = expenses;

            // Toplam gelir ve gider hesaplama
            decimal totalIncome = incomes.Sum(x => x.Amount);
            decimal totalExpense = expenses.Sum(x => x.Amount);



            // Toplam gelir ve gideri Label'lara göster
            lblTotalIncome.Text = $"Toplam Gelir: {totalIncome:C}";
            lblTotalExpense.Text = $"Toplam Gider: {totalExpense:C}";

            // Label renklerini değiştir (isteğe bağlı)
            lblTotalIncome.ForeColor = Color.Green;
            lblTotalExpense.ForeColor = Color.Red;


            decimal totalIncome2 = _context.Incomes
        .Where(i => i.Date.Month == month)
        .Sum(i => i.Amount);

            // Gider verilerini getir ve toplamını al
            decimal totalExpense2 = _context.Expenses
                .Where(e => e.Date.Month == month)
                .Sum(e => e.Amount);

            // ProgressBar'ın maksimum değerini toplam gelir + toplam gider olacak şekilde ayarla
            progressBar1.Maximum = (int)(totalIncome2 + totalExpense2);
            progressBar1.Value = (int)totalIncome2;  // Yalnızca gelir için gösterim yapabilirsiniz ya da gider için.



        }

    }
}
