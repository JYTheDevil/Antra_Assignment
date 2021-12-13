using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Data.Entities;
namespace Data.Repositories
{
    public class No9_Repo : No9_IRepo<Minions>
    {
        DbContext db;
        public No9_Repo()
        {
            db = new DbContext();
        }
        public Minions Update(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                var m = conn.Query<Minions>("usp_GetOlder",new { id = id}, commandType:System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return m;
            }
        }
    }
}