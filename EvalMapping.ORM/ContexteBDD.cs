using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EvalMapping.ORM;

namespace EvalMapping.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD()
            : base("ChaineDeConnexion")
        {

        }

        /*public DbSet<Course> Courses { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<Person> persons { get; set; }
        public DbSet<Departement> Departements { get; set; }*/


    }
}
