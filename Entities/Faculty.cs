using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Faculty
    {
        #region Properties
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }

        #endregion

        #region Releations

        public List<Department> Departments { get; set; }

        #endregion
    }
}
