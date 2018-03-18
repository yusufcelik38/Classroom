using Classroom.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Classroom.ServiceHost.API.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentEngine _studentEngine;
        public StudentController(IStudentEngine studentEngine)
        {
            _studentEngine = studentEngine;
        }
        public string Get(int id)
        {
            return _studentEngine.Get(id);
        }
    }
}
