using BudgetManagement.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagement.DataAccess.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BCNGC9H\SQLEXPRESS01;Initial Catalog=BudgetDB;Integrated Security=True; Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DB tablolarımız oluşturulurken onlara müdehale edebiliriz.


            //modelBuilder.Entity<Income>().HasOne<Category>().WithMany().
            //    HasForeignKey(i => i.Category);

            //modelBuilder.Entity<Expense>().HasOne<Category>().WithMany().
            //   HasForeignKey(e => e.Category);

        }

    }

}
