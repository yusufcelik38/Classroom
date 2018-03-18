using Classroom.Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Business.Contracts
{
    public interface ITeacherEngine:IBusinessEngine
    {
        string Get(int id);
    }
}
