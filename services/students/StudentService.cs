using dependencyinjectiontest.daos;
using dependencyinjectiontest.models.universities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.services
{
    class StudentService : IStudentService
    {
        private StudentDao _studentDao;

        public StudentService(StudentDao studentDao)
        {
            _studentDao = studentDao;
        }

        public List<Student> GetBestStudents()
        {
            List<Student> students = _studentDao.getAll();
            // здесь должна быть бизнес-логика, например проход в цикле по списку и вычисление лучших студентов по рейтингу и другим параметрам
            // и возвращение как минимум 2-3 ошибок бизнес-логики
            // if (...)
            throw new Exception("Студентов нет");
            //.. или if (...)
            throw new Exception("...другая ошибка бизнес-логики...");

            return students;
        }
    }
}
