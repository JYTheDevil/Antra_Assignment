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
    public class No5_Repo:No5_IRepo
    {
        DbContext _db;
        public No5_Repo()
        {
            _db = new DbContext();
        }

        public dynamic ChangeCasing(string str)
        {
            using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
            {
                dynamic d = conn.Query(@"select c.Name CountryName, UPPER(t.Name) TownName
                             from Towns t join Countries c
                             on t.CountryId= c.Id
                             where c.Name = @str
                             ", new { str = str });
                return d;
            }
        }
    }
}
