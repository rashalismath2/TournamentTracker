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
        
        /// <summary>
        /// Store the model info in table
        /// </summary>
        /// <param name="model">Takes a model object</param>
        /// <returns>If model has been saved returns that mode else returns null</returns>
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


        public PersonModel CreatePerson(PersonModel model)
        {
            string sql = @"INSERT INTO people (FirstName,LastName,EmailAddress,ContactNumber) values(@FirstName,@LastName,@EmailAddress
                ,@ContactNumber)";

            var affectedRows = connection.Execute(sql, new[] {
                new {FirstName=model.FirstName,LastName=model.LastName,EmailAddress=model.EmailAddress,ContactNumber=model.ContactNumber }
            });

            if (affectedRows == 1)
            {
                return model;
            }
            return model = null;
        }

       
        public List<PersonModel> GetAllPeople()
        {
            string sql = "SELECT * from people";
            List<PersonModel> list = connection.Query<PersonModel>(sql).ToList();

            return list;
        }
    }
}
