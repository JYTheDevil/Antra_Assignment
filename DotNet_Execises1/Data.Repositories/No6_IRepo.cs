using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface No6_IRepo<T> where T : class
    {
        int DeleteMV(int id);
        T DeleteV(int id);
    }
}
