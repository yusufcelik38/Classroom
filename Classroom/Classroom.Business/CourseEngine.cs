using Classroom.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Business
{
    public class CourseEngine : BusinessEngineBase, ICourseEngine
    {
        private readonly ICourseEngine _courseEngine;
        public CourseEngine(ICourseEngine courseEngine)
        {
            _courseEngine = courseEngine;
            Debug.WriteLine("CourseEngine girildi!");
        }

        public string Get(int id)
        {
            return "Get edildi" + id.ToString();
        }
    }
}
