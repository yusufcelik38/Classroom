using Classroom.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Business
{
    public class StudentEngine:BusinessEngineBase,IStudentEngine
    {
        private readonly IStudentEngine _studentEngine;
        public StudentEngine(IStudentEngine studentEngine)
        {
            _studentEngine = studentEngine;
        }

        public string Get(int id)
        {
            
            return id.ToString();
        }
    }
}
