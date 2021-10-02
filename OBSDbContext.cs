using k2_CodeFirstWithMigrations.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations
{
    public class OBSDbContext : DbContext
    {
        public OBSDbContext()
        {
            this.Database.Connection.ConnectionString = "Server=.;Database=OBSDb;User Id=sa;Password=123;";
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentLesson> DepartmentLessons { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
