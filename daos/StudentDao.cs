
using dependencyinjectiontest.models.daos;
using dependencyinjectiontest.models.universities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.daos
{
    class StudentDao : Dao<Student>
    {
        public StudentDao(DatabaseConnection db) : base(db, "student")
        {
        }

        // Здесь реализуются специфичные запросы для конкретной сущности
        // например получить всех отчисленных студентов
        // получить всех студентов определенной группы, отсортированных по рейтингу

    }
}
