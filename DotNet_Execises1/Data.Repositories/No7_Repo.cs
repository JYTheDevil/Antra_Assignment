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
    public class No7_Repo
    {
        DbContext _db;
        public No7_Repo()
        {
            _db = new DbContext();
        }
        public dynamic GetMinionsName(int id)
        {
            using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
            {
                dynamic d = conn.QueryFirstOrDefault<Minions>(@"select Name from Minions");
                return d;
            }
        }
    }
}
