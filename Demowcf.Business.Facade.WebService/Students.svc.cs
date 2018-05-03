using Demowcf.Business.Logic;
using Demowcf.Common.Logic.Model;
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
        private readonly IDemowcfBLService _demowcfBLService;

        public Students()
        {
            _demowcfBLService = new DemowcfBLService();
        }

        public Student Create(Student student)
        {
            return _demowcfBLService.Create(student);
        }

        public void Delete(int idStudent)
        {
            _demowcfBLService.Delete(idStudent);
        }

        public Student Get(string idStudent)
        {
            return _demowcfBLService.Get(idStudent);
        }

        public List<Student> GetAll()
        {
            return _demowcfBLService.GetAll();
        }

        public Student Update(Student student)
        {
            return _demowcfBLService.Update(student);
        }

    }
}
