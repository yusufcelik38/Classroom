using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Data.Entities
{
    public class Student:EntityBase<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SchoolNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
