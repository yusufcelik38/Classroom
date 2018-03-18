using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ClassroomContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }
    }
}
