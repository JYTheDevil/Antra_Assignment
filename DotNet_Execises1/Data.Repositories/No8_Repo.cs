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
    public class No8_Repo : IRepositories<Minions>
    {
        DbContext db;
        public No8_Repo()
        {
            db = new DbContext();
        }
        public Minions Update(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Query <Minions>(@"update Minions set Age = Age + 1 where id=@id", new {id = id});
                Minions m = conn.QueryFirstOrDefault<Minions>(@"select Name , Age from Minions where id = @id", new {id =id});
                return m;
            }
        }
    }
}
