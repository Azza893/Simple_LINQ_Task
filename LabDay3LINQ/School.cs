using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay3LINQ
{
    class School
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<TeacherTrans> fromSchool { get; set; }
        public virtual ICollection<TeacherTrans> ToSchool { get; set; }
    }
}
