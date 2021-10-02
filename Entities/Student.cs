using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Student
    {
        #region Properties

        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        #endregion

        #region Releation

        public int ConsultantTrainerID { get; set; }
        public Trainer ConsultantTrainer { get; set; }


        public List<StudentLesson> StudentLessons { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }



        #endregion
    }
}
