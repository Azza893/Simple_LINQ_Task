using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay3LINQ
{
    class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NID { get; set; }
        public string Code { get; set; }
        public string Job { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }
        public DateTime BrithDate { get; set; }
        public DateTime HiringDate { get; set; }
        public string Qualification { get; set; }
        public DateTime QualificationDate { get; set; }
        public School school { get; set; }
        public Address address { get; set; }
       
    }
}
