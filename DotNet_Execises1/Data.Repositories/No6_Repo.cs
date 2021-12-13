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
        public Villains Update(int id)
        {
            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                //conn.Query<Villains>(@"begin tran
                //                       delete from MinionsVillains 
                //                       where @id = id
                //                       delete from Villains
                //                       output deleted.[name], deleted.[id]
                //                       where @id = id", new { id = id });
                Villains m = conn.QueryFirstOrDefault<Villains>(@"begin tran
                                                                  delete from MinionsVillains 
                                                                  where VillainId = @id
                                                                  delete from Villains
                                                                  output deleted.[name]
                                                                  where id = @id", new { id = id });
                return m;
            }
        }
    }
}
