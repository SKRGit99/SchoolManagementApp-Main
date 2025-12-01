using SchoolManagementAppWeb.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementAppWeb.Data
{
    public class StudentInfoDbContext:DbContext
    {
        public StudentInfoDbContext()
        {
        }

        public StudentInfoDbContext(DbContextOptions<StudentInfoDbContext> options) : base(options)
        {
        }
        public DbSet<StudentInfoEF> StudentInfoUsingIEnumerable { get; set; }

        public DbSet<StudentInfoEF> StudentInfoUsingList { get; set; }
        public DbSet<StudentInfoForDropdownEF> StudentDetailsForDropdown { get; set; }
    }
}
