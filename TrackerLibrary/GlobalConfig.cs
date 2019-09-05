using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    /// <summary>
    /// Let use different connections to store data.
    /// Inthis case we have used sql or textfile
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// Setting a database connection type
        /// </summary>
        public static IDataconnection Connection { get; private set; }
       
        /// <summary>
        /// Letting choose to either Sql ortextfile as the database
        /// </summary>
        /// <param name="db">DatabaseConnectionType Enum</param>
        public static void InitializeConnection(DatabaseConnectionTypes db) {

            if (db==DatabaseConnectionTypes.MySql) {
                Connection=new SqlConnector(SqlConnectionSingleton.getMySqlConnection());
            }
            
            else if (db == DatabaseConnectionTypes.TextFile) {
                //Connection=new TextConnector();
            }
        }

        /// <summary>
        /// Used to get the connection string
        /// </summary>
        /// <param name="name">Connection string name</param>
        /// <returns>returns a string value of connection</returns>
        public static string ConnectionString(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
