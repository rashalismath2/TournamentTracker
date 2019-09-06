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

        public TeamModel CreateTeam(TeamModel team)
        {
            //insert team name in team table
            string sql = "INSERT INTO teams (TeamName) values (@TeamName)";

            int affectedRows = connection.Execute(sql, new { TeamName = team.TeamName });

            //get the team id from the database
            if (affectedRows == 1)
            {
                sql = "SELECT * FROM teams WHERE TeamName=@TeamName";
                TeamModel record = connection.Query<TeamModel>(sql, new { TeamName = team.TeamName }).Single();

                //store the team members and team id on the teams_has_people table

                foreach (PersonModel person in team.TeamMembers)
                {
                    sql = "INSERT INTO teams_has_people (Teams_id,People_id) values (@Teams_id,@People_id)";
                    affectedRows = connection.Execute(sql, new { Teams_id = record.id, People_id = person.id });

                    if (affectedRows != 1)
                    {
                        return team = null;
                    }
                }
            }
            else {
                return team = null;
            }


            return team;
        }
    }
}
