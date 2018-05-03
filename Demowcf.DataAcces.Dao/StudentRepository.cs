using Demowcf.Common.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demowcf.DataAcces.Dao
{
    public class StudentRepository<T> : IStudentRepository<T> where T : Student
    {
        public void Delete(int idStudent)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Insert(T item)
        {

            try
            {
                var student = item as Student;

                using (var context = new StudentContext())
                {
                    context.students.Add(student);
                    context.SaveChanges();

                    return (T)Convert.ChangeType(student, typeof(T));
                }
            }catch(Exception e)
            {
                throw e;
            }

        }

        public T SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(int id, T item)
        {
            throw new NotImplementedException();
        }
    }
}
