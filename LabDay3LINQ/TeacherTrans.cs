using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay3LINQ
{
    class TeacherTrans
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        //[ForeignKey("fromschoolID")]
        public int fromschoolID { get; set; }
        //[ForeignKey("ToschoolID")]
        public int ToschoolID { get; set; }
        public School FromSchool { get; set; }
        public School ToSchool  { get; set; }
        public Teacher teacher { get; set; }

    }
}
