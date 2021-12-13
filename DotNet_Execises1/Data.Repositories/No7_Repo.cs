using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Data.Entities;
using System.Data.SqlClient;
namespace Data.Repositories
{
    public class No7_Repo : No7_IRepo<Minions>
    {
        DbContext _db;
        public No7_Repo()
        {
            _db = new DbContext();
        }
        public Minions GetMinionsName(int id)
        {
            using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
            {
                Minions d = conn.QueryFirstOrDefault<Minions>(@"select Name from Minions where @id = id",new {id = id});
                return d;
            }
        }
        public dynamic GetMinionsName()
        {
            using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
            {
                dynamic d = conn.Query(@"select Name from Minions");
                return d;
            }
        }
    }
}
