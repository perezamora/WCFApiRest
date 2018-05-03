using Demowcf.Common.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demowcf.Business.Logic
{
    public interface IDemowcfBLService
    {
        List<Student> GetAll();
        Student Get(string idStudent);
        Student Create(Student student);
        Student Update(Student student);
        void Delete(int idStudent);
    }
}
