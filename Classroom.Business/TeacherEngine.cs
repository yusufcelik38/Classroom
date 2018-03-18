using Classroom.Business.Contracts;
using Classroom.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Business
{
    public class TeacherEngine : BusinessEngineBase, ITeacherEngine
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherEngine(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        
        public string GetAsync(int id)
        {
            return "Get";
        }
        
    }
}
