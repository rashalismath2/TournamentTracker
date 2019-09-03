using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{   
    /// <summary>
    ///     Implelements IDataConnection Interface to add data into sql database
    /// </summary>
    public class SqlConnector : IDataconnection
    {
        public MySqlConnection connection { get; set; }
        public SqlConnector(MySqlConnection connection) {
            this.connection = connection;
        }
        //TODo - add logics to save prize model into the database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            string sql = @"INSERT INTO prizes (PlaceNumber,PlaceName,PrizePrecentage,PrizeAmount) values(@PlaceNumber,@PlaceName,@PrizePrecentage
                ,@PrizeAmount)";

            var affectedRows = connection.Execute(sql,new[] {
                new {PlaceNumber=model.PlaceNumber,PlaceName=model.PlaceName,PrizePrecentage=model.PrizePrecentage,PrizeAmount=model.PrizeAmount }
            });

            if (affectedRows==1) {
                return model;
            }
            return model = null;
        }
    }
}
