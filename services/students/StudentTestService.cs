using dependencyinjectiontest.daos;
using dependencyinjectiontest.models.universities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.services
{
    class StudentTestService
    {
        private StudentDao _studentDao;

        public StudentTestService(StudentDao studentDao)
        {
            // хранилище данных тоже может быть интерфейсом IStudentDao
            // что позволит использовать тестовые данные 
            _studentDao = studentDao;
        }

        public List<Student> GetBestStudents()
        {
            List<Student> students = _studentDao.getAll();

            // здесь должна быть тестовая бизнес-логика

            return students;
        }
    }
}
