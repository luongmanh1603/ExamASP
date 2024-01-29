using ExamDepartment.Data;
using ExamDepartment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ExamDepartment.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExamDepartmentContext(serviceProvider.GetRequiredService<DbContextOptions<ExamDepartmentContext>>()))
            {
                // Kiểm tra xem có bất kỳ dữ liệu nào trong database chưa
                if (context.Department.Any() || context.Employee.Any())
                {
                    return; // Database đã được khởi tạo
                }

                // Seed dữ liệu cho Department
                context.Department.AddRange(
                    new Department
                    {
                        DepartmentName = "Accounting Department",
                        DepartmentCode = "ACC",
                        Location = "Headquarters",
                        NumberOfEmployees = 20
                    },
                    new Department
                    {
                        DepartmentName = "Production Management Department",
                        DepartmentCode = "PROD",
                        Location = "Factory",
                        NumberOfEmployees = 50
                    },
                    new Department
                    {
                        DepartmentName = "Human Resources Department",
                        DepartmentCode = "HR",
                        Location = "Headquarters",
                        NumberOfEmployees = 15
                    },
                    new Department
                    {
                        DepartmentName = "IT Department",
                        DepartmentCode = "IT",
                        Location = "Headquarters",
                        NumberOfEmployees = 30
                    }
                );

                // Seed dữ liệu cho Employee
                context.Employee.AddRange(
                    new Employee
                    {
                        EmployeeName = "John Doe",
                        EmployeeCode = "JD001",
                        Rank = "Manager",
                        DepartmentId = 1 // Chọn phòng ban theo DepartmentId
                    },
                    new Employee
                    {
                        EmployeeName = "Jane Smith",
                        EmployeeCode = "JS002",
                        Rank = "Engineer",
                        DepartmentId = 2
                    },
                    new Employee
                    {
                        EmployeeName = "Bob Johnson",
                        EmployeeCode = "BJ003",
                        Rank = "HR Specialist",
                        DepartmentId = 3
                    },
                    new Employee
                    {
                        EmployeeName = "Alice Williams",
                        EmployeeCode = "AW004",
                        Rank = "Developer",
                        DepartmentId = 4
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
