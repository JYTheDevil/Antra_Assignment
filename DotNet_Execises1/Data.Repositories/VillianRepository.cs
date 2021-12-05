using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Data.Entities;
using Dapper;

namespace Data.Repositories
{
    public class VillianRepository : IVillianRepo
    {
        DbContext _db;
        public VillianRepository()
        {
            _db = new DbContext();
        }

        

        //public int Insert(Villains entity)
        //{
        //    //string cmd = "Insert into villains values(@name,@evilnessId)";
        //    //Dictionary<string, object> parameters = new Dictionary<string, object>();
        //    //parameters.Add("@name", entity.Name);
        //    //parameters.Add("@evilnessId", entity.EvilnessFactorId);
        //    //return _db.Execute(cmd, parameters);
        //}
        public dynamic GetVillianName()
        {
            using (SqlConnection conn = new SqlConnection(_db.GetConnectionString()))
            {
                dynamic d =  conn.Query(@"select v.Name, COUNT(mv.MinionId) total
                from Villains v join MinionsVillains mv
                on v.Id = mv.VillianId
                join Minions m
                on mv.MinionId = m.Id
                group by v.Name
                having COUNT(mv.MinionId) > 3");
                return d;
            }
        }



    }
}
