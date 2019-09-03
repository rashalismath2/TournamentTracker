﻿using System;
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
        /// List can include either sql or textfile connections
        /// </summary>
        public static List<IDataconnection> Connections { get; private set; } = new List<IDataconnection>();

        /// <summary>
        /// Application can store data in qither or both as sql and textfiles
        /// </summary>
        /// <param name="sql">If we want to store in sql this is true</param>
        /// <param name="textfile">If we want to store in textfile this is true</param>
        public static void InitializeConnection(bool sql,bool textfile) {

            if (sql) {
                Connections.Add(new SqlConnector(SqlConnectionSingleton.getMySqlConnection()));
            }
            
            if (textfile) {
                Connections.Add(new TextConnector());
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
