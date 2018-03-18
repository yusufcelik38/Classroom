using Classroom.Business.Contracts;
using Classroom.Data.Contracts;
using Classroom.Data.DataRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Business
{
    public class StudentEngine : BusinessEngineBase, IStudentEngine
    {
        private readonly IStudentRepository _studentRepository;

        public StudentEngine(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public string GetAsync(int id)
        {
            return "Get";
        }

    }
}
