using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using System.Data.SqlClient;
using Dapper;

namespace Data.Repositories
{
    public class MinionRepository :  IMinionNameRepo2
    {
        DbContext _db;
        public MinionRepository()
        {
            _db = new DbContext();
        }

        public bool checkExist(int id)
        {
            using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
            {
                var exists = conn.ExecuteScalar<bool>("select count(1) from Villains where Id=@id", new { id });
                return exists;
            }
        }

        public dynamic GetMinionsName(int id)
        {
            using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
            {
                dynamic d = conn.Query(@"select v.Id VilliansId, v.Name VilliansName, m.Name MinionsName, m.Age
                from Villains v join MinionsVillains mv
                on v.Id = mv.VillianId
                join Minions m 
                on mv.MinionId = m.Id
                where v.Id = @id
                order by m.Name asc", new { id = id });
                return d;
            }
        }
    }

}
