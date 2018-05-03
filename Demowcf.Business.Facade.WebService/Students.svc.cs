using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Demowcf.Business.Facade.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Students" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Students.svc or Students.svc.cs at the Solution Explorer and start debugging.
    public class Students : IStudents
    {

        private List<Student> repo;

        public Students()
        {
            repo = new List<Student>
            {
                new Student() { Id = 1, Name = "Peter", Surname = "Parker" },
                new Student() { Id = 2, Name = "Lobezno", Surname = "su" },
                new Student() { Id = 3, Name = "Tormenta", Surname = "de verano" },
                new Student() { Id = 4, Name = "Spider", Surname = "man" }
            };
        }

        public Student Create(Student student)
        {
            if (student != null)
            {
                if (student.Id == 0)
                {
                    int maxCliente = repo.Max(c => c.Id);
                    student.Id = maxCliente + 1;
                }
                repo.Add(student);
            }
            return student;
        }

        public void Delete(int idStudent)
        {
            if (idStudent > 0)
            {
                Student cli = ObtenerStudent(idStudent);
                if (cli != null)
                {
                    repo.Remove(cli);
                }
            }
        }

        public Student Get(string idStudent)
        {
            int.TryParse(idStudent, out int id);
            return ObtenerStudent(id);
        }

        public List<Student> GetAll()
        {
            return repo;
        }

        public Student Update(Student student)
        {
            Student cli = null;
            if (student != null)
            {
                cli = ObtenerStudent(student.Id);
                if (cli != null)
                {
                    cli.Name = student.Name;
                    cli.Surname = student.Surname;
                }
            }
            return cli;
        }

        private Student ObtenerStudent(int idStudent)
        {
            Student cli = repo.Where(c => c.Id == idStudent).Select(c => c).SingleOrDefault();
            return cli;
        }

    }
}
