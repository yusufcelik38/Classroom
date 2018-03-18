using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Data.Entities
{
    public class Course:EntityBase<int>
    {
        public string ConfirmationCode { get; set; }
        public DateTime ActivetedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Description { get; set; }
        public string ModeofDelivery { get; set; }
        public string CourseObjective { get; set; }
        public string Language { get; set; }


        //Öğretmen ilişkisi olacak
        //Ödev ilişkisi olacak
        //m-n öğrenci

    }
}
