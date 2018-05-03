using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demowcf.DataAcces.Dao
{
    public interface IStudentUpdateDao<T>
    {
        T Update(int id, T item);
    }
}
