using dependencyinjectiontest.daos;
using dependencyinjectiontest.models.universities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.services
{
    interface IStudentService
    {
        List<Student> GetBestStudents();
    }
}
