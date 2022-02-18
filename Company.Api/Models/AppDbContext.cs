using Company.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Company.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings").Build();
            
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
          
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Ravi",
                LastName = "Kumar",
                Email = "Ravi.kumar@company.com",
                DateOfBrith = new DateTime(1999, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/ravi.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Sid",
                LastName = "Kumar",
                Email = "Sid.kumar@company.com",
                DateOfBrith = new DateTime(2001, 12, 12),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/sid.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Rupa",
                LastName = "Shree",
                Email = "rupa.shree@company.com",
                DateOfBrith = new DateTime(2000, 11, 14),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/rupa.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Sara",
                LastName = "Grover",
                Email = "sara.grover@company.com",
                DateOfBrith = new DateTime(2002, 9, 12),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/sara.png"
            });
        }
    }
}
