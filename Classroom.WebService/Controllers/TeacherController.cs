using Classroom.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Classroom.WebService.Controllers
{
    public class TeacherController : ApiController
    {
        private readonly ITeacherEngine _teacherEngine;
        public TeacherController(ITeacherEngine teacherEngine)
        {
            _teacherEngine = teacherEngine;
        }
        public string Get(int id)
        {
            return _teacherEngine.GetAsync(id);
        }
    }
}