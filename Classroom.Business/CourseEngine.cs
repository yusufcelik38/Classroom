using Classroom.Business.Contracts;
using Classroom.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Business
{
    public class CourseEngine : BusinessEngineBase, ICourseEngine
    {
        private readonly ICourseRepository _courseRepository;

        public CourseEngine(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public string GetAsync(int id)
        {
            return "Get";
        }

    }
}
