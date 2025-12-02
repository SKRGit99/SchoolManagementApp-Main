using SchoolManagementAppWeb.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementAppWeb.Data
{
    public class SchoolApplicationDbContext:DbContext
    {
        public SchoolApplicationDbContext()
        {
        }

        public SchoolApplicationDbContext(DbContextOptions<SchoolApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<StudentDetailsEF> StudentDetailsEF { get; set; }
        public DbSet<StudentDetailsForDropdownEF> StudentDetailsForDropdownEF { get; set; }

        public DbSet<EducatorDetailsEF> EducatorDetailsEF { get; set; }
        public DbSet<EducatorDetailsForDropdownEF> EducatorDetailsForDropdownEF { get; set; }
    }
}
