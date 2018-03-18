using Classroom.Data.Contracts;
using Classroom.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Data.DataRepositories
{
    public class CourseRepository: RepositoryBase<Course,int>,ICourseRepository
    {
        public CourseRepository(DbContext dbContext)
            :base(dbContext)
        {

        }
    }
}
