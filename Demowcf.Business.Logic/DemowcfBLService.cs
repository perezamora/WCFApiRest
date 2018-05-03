using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demowcf.Common.Logic.Model;
using Demowcf.DataAcces.Dao;

namespace Demowcf.Business.Logic
{
    public class DemowcfBLService : IDemowcfBLService
    {
        private readonly IStudentRepository<Student> _studentRepository;

        public DemowcfBLService(IStudentRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student Create(Student student)
        {
            return _studentRepository.Insert(student);
        }

        public void Delete(int idStudent)
        {
            _studentRepository.Delete(idStudent);
        }

        public Student Get(string idStudent)
        {
            return _studentRepository.SelectById(Convert.ToInt32(idStudent));
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll(); ;
        }

        public Student Update(Student student)
        {
            return _studentRepository.Update(student.Id, student);
        }
    }
}
