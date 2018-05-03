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

        #region Public Methods
        public void Delete(int idStudent)
        {
            try
            {
                using (var context = new StudentContext())
                {
                    var student = context.Students
                    .Where(alumno => alumno.Id == idStudent)
                    .FirstOrDefault();

                    context.Students.Remove(student);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> GetAll()
        {
            try
            {
                using (var context = new StudentContext())
                {
                    var students = from student in context.Students
                                   select student;

                    var listaStudents = students.ToList<Student>();
                    return (List<T>)Convert.ChangeType(listaStudents, typeof(List<T>));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Insert(T item)
        {
            try
            {
                var student = item as Student;

                using (var context = new StudentContext())
                {
                    context.Students.Add(student);
                    context.SaveChanges();

                    return (T)Convert.ChangeType(student, typeof(T));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public T SelectById(int id)
        {
            try
            {
                using (var context = new StudentContext())
                {
                    var alumno = context.Students
                    .Where(student => student.Id == id)
                    .FirstOrDefault();

                    return (T)Convert.ChangeType(alumno, typeof(T));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Update(int id, T item)
        {
            try
            {
                var student = item as Student;

                using (var context = new StudentContext())
                {
                    var studentUpdate = context.Students
                                .Where(alumno => alumno.Id == id)
                                .FirstOrDefault();
                    studentUpdate.Name = student.Name;
                    studentUpdate.Surname = student.Surname;

                    context.SaveChanges();
                    return (T)Convert.ChangeType(studentUpdate, typeof(T));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
