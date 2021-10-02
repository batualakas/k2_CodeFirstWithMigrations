using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Department
    {
        #region Properties
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        #endregion

        #region Releations
        public int FacultyID { get; set; }
        public Faculty Faculty { get; set; }

        public List<Student> Students { get; set; }

        public List<DepartmentLesson> DepartmentLessons { get; set; }

        #endregion
    }
}
