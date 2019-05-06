using dependencyinjectiontest.models.daos;
using dependencyinjectiontest.models.universities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.daos
{
    class FacultyDao : Dao<Faculty>
    {
        public FacultyDao(DatabaseConnection db) : base(db, "faculty")
        {
        }
    }
}
