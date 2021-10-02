using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigrations.Entities
{
    public class Trainer
    {

        #region Properties
        public int TrainerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        #endregion

        #region Releations

        public List<Student> Students { get; set; }

        public List<Lesson> Lessons { get; set; }

        #endregion
    }
}
