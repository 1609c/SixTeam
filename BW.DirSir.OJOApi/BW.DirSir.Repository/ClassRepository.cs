using BW.DirSir.IRepository;
using BW.DirSir.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.DirSir.Repository
{
    public class ClassRepository : IClassRepository
    {
        public static readonly string _connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public List<Class> GetClassList()
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                var sql = "select * from Student";
                var query = conn.Query<Class>(sql).ToList();
                return query;
            }
        }
    }

}
