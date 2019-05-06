using dependencyinjectiontest.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.models.daos
{
    abstract class Dao<T> {

        private String TableName;

        protected Dao(DatabaseConnection db, String tableName)
        {
            TableName = tableName;
        }

        public List<T> getAll()
        {
            List<T> entities = new List<T>();
            // запрос к базе на выборку всех записей
            // db.query("SELECT * FROM {0}", TableName)... 
            // обход в цикле с конвертацией ConvertRowsToEntities(DataRow row) и наполнением списка entities.add(entity)

            return entities;
        }

        public T getById(int id)
        {
            // SQL запрос на выборку нужной записи по id
            // Создание элемента сущности нужного типа 
            T element = ConvertRowToEntity("asad");
            // конвертация 
            // element.FromValues(valueMap);
            return element;
        }

        // Метод конвертирует данные из базы в объект нужной сущности
        public T ConvertRowToEntity(String row)
        {
            T element = (T)Activator.CreateInstance(typeof(T));
            //element.FromValues(valueMap);
            return element;
        }

        // .. и другие методы обновления и вставки
    }
}
