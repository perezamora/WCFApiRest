using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demowcf.DataAcces.Dao
{
    public interface IStudentRepository<T> : IStudentCreateDao<T>, IStudentReadDao<T>, IStudentUpdateDao<T>, IStudentDeleteDao<T>
    {
    }
}
