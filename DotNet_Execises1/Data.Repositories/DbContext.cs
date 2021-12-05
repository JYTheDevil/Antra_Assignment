using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
namespace Data.Repositories
{
    internal class DbContext
    {
        //public int Execute(string cmd, Dictionary<string,object> parameters)
        //{
        //    string connection = "Data Source=localhost;Initial Catalog=MinionsDB;Integrated Security=True";

        //    using (SqlConnection con = new SqlConnection(connection)) { 
                
        //    con.Open();

        //    SqlCommand sqlCommand = new SqlCommand();
        //    sqlCommand.CommandText = cmd;

        //    if(parameters != null)
        //    {
        //        foreach (var item in parameters)
        //        {
        //            sqlCommand.Parameters.AddWithValue(item.Key,item.Value);
        //        }
        //    }

        //    sqlCommand.Connection = con;
        //    int r = sqlCommand.ExecuteNonQuery();
        //    con.Close();
        //    return r;
        //    };
        //}
        //public DataTable Query(string cmd, Dictionary<string, object> parameters)
        //{
        //    string connection = "Data Source=localhost;Initial Catalog=MinionsDB;Integrated Security=True";
        //    using (SqlConnection con = new SqlConnection(connection))
        //    {
        //        con.Open();
        //        SqlCommand sqlcmd = new SqlCommand();
        //        sqlcmd.CommandText = cmd;
        //        sqlcmd.Connection = con;

        //        if(parameters!= null)
        //        {
        //            foreach (var item in parameters)
        //            {
        //                sqlcmd.Parameters.AddWithValue(item.Key, item.Value);
        //            }
        //        }
        //       SqlDataReader reader = sqlcmd.ExecuteReader();
        //        DataTable dt = new DataTable();
        //        dt.Load(reader);
        //        con.Close();
        //        return dt;
        //    };
        //}

        public string GetConnectionString()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            return builder.AddJsonFile("appSettings.json").Build().GetConnectionString("MinionsDB");
        }
    }
}
