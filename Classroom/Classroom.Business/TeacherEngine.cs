using Classroom.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Business
{
    public class TeacherEngine:BusinessEngineBase,ITeacherEngine
    {
        private readonly ITeacherEngine _teacherEngine;
        public TeacherEngine(ITeacherEngine teacherEngine)
        {
            _teacherEngine = teacherEngine;
            Debug.WriteLine("TeacherEngine girildi!");
        }

        public string Get(int id)
        {
            return "Get edildi" + id.ToString();
        }
    }
}
