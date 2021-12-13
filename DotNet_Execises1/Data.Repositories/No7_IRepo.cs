using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface No7_IRepo<T> where T : class
    {
        T GetMinionsName(int id);
        dynamic GetMinionsName();
    }
}
