using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Lesson
    {
        #region Properties
        public int LessonID { get; set; }
        public string LessonCode { get; set; }
        public string LessonName { get; set; }

        #endregion

        #region Releations

        public List<StudentLesson> StudentLessons { get; set; }

        public List<DepartmentLesson> DepartmentLessons { get; set; }

        public int TrainerID { get; set; }
        public Trainer Trainer { get; set; }

        #endregion
    }
}
