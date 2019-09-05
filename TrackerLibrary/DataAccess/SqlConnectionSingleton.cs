using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnectionSingleton
    {
        private static MySqlConnection instance;

        //Default database Name
        public static string dbName { get; set; } = "csharpapplication";


        private SqlConnectionSingleton() { }

        public static MySqlConnection getMySqlConnection() {
            if (instance==null) {
                return new MySqlConnection(GlobalConfig.ConnectionString(dbName));
            }

            return instance;
        }
    }
}
