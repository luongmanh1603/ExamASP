using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamDepartment.Models;

namespace ExamDepartment.Data
{
    public class ExamDepartmentContext : DbContext
    {
        public ExamDepartmentContext (DbContextOptions<ExamDepartmentContext> options)
            : base(options)
        {
        }

        public DbSet<ExamDepartment.Models.Department> Department { get; set; } = default!;

        public DbSet<ExamDepartment.Models.Employee> Employee { get; set; } = default!;
    }
}
