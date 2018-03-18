﻿using Classroom.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Data.Contracts
{
    public interface IStudentRepository : IRepository<Student, int>
    {
    }
}
