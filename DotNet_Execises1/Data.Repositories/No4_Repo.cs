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
    public class No4_Repo : No4_IRepo<Minions>
    {
        DbContext db;
        public No4_Repo()
        {
            db = new DbContext();
        }
        public int Insert(Minions entity)
        {
            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                 return conn.Execute("insert into minions values (@Id,@Name,@Age,@TownId)",entity);  
            }
        }

        
    }
}
