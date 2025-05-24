using EKart.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKart.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }
        public int DegreeProgramId { get; set; }
        public DegreeProgram DegreeProgram { get; set; }
        public int YearLevelId { get; set; }
        public YearLevel yearLevel { get; set; }



    }
}
