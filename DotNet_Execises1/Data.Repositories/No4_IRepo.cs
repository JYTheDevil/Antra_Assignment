using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface No4_IRepo<T> where T : class
    {
         int Insert(T entity);
    }
}
