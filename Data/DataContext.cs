using ExcelReader.Models;
using Microsoft.EntityFrameworkCore;

namespace ExcelReader.Data
{
    public class DataContext
    {
        public DbSet<EmployeeDetails> EmployeesDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\ExcelReaderDb;Initial Catalog=PhonebookDb;Integrated Security=true;TrustServerCertificate=True");
        }
    }
}