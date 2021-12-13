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
    public class No6_Repo : No6_IRepo<Villains>
    {
        DbContext db;
        public No6_Repo()
        {
            db = new DbContext();
        }
        public int DeleteMV(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                return conn.Execute("delete from MinionsVillains where VillianId = @id ", new { id = id });
            }
        }
        public Villains DeleteV(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                Villains d =  conn.QueryFirstOrDefault<Villains>(" delete from Villains output deleted.[name] where id = @id ", new { id = id });
                return d;
            }
        }
    }
}
