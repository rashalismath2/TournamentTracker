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
           DateTime today=DateTime.Now;
         
            string sql = @"INSERT INTO prizes (PlaceNumber,PlaceName,PrizePrecentage,PrizeAmount,created_date) values(@PlaceNumber,@PlaceName,@PrizePrecentage
                ,@PrizeAmount,@created_date)";

            var affectedRows = connection.Execute(sql,new[] {
                new {PlaceNumber=model.PlaceNumber,PlaceName=model.PlaceName,PrizePrecentage=model.PrizePrecentage,PrizeAmount=model.PrizeAmount,created_date=today.ToString("yyyy,MM,dd HH:mm:ss") }
            });

            if (affectedRows==1) {
                sql = "SELECT id from prizes where created_date=@created_date";
                Console.WriteLine(today);
                var i=connection.Query<int>(sql,new { created_date = today.ToString("yyyy,MM,dd HH:mm:ss") }).Single();
                model.id = i;
                return model;
            }
            return model = null;
        }


        public PersonModel CreatePerson(PersonModel model)
        {
            DateTime time = DateTime.Now;
            string sql = @"INSERT INTO people (FirstName,LastName,EmailAddress,ContactNumber,created_date) values(@FirstName,@LastName,@EmailAddress
                ,@ContactNumber,@created)";

            var affectedRows = connection.Execute(sql, new[] {
                new {FirstName=model.FirstName,LastName=model.LastName,EmailAddress=model.EmailAddress,ContactNumber=model.ContactNumber,created=time.ToString("yyyy,MM,dd HH:mm:ss")}
            });

            if (affectedRows == 1)
            {
                sql = "SELECT id from people where created_date=@date";
                int id = connection.Query<int>(sql, new { date = time.ToString("yyyy,MM,dd HH:mm:ss") }).Single();
                model.id = id;
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
                team.id = record.id;
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

        public List<TeamModel> GetAllTeam()
        {
            string sql = "SELECT * from teams";
            List<TeamModel> teams = connection.Query<TeamModel>(sql).ToList();

            if (teams!=null) {

                foreach (TeamModel team in teams) {
                    sql = "SELECT * from people where id in(select people_id from teams_has_people where teams_id=@team_id)";
                    List<PersonModel> person = connection.Query<PersonModel>(sql, new { team_id = team.id }).ToList();
                    team.TeamMembers = person;
                }

                return teams;
            }
            return teams = null;
        }

        public TournamentModel CreateTrounament(TournamentModel model)
        {
            //TODO - Break down these codes to methods
            #region Insert into tournaments

            DateTime time = DateTime.Now;
   
            string sql = "INSERT INTO tournaments (TournamentName,EntryFee,created_date) values(@name,@fee,@created)";
            var affectedRows = connection.Execute(sql, new { name=model.TournamentName,fee=model.EntryFee,created= time.ToString("yyyy,MM,dd HH:mm:ss") });
            //if entering into tournaments successfull
            if (affectedRows == 1)
            {
                sql = "SELECT id from tournaments where created_date=@created";
                var tournamentId = connection.Query<int>(sql, new { created = time.ToString("yyyy,MM,dd HH:mm:ss") }).Single();
                if (tournamentId >= 1)
                {
                    model.id = tournamentId;
                }
                else
                {
                    return model = null;
                }
            }
            else {
                return model = null;
            }

            #endregion

            #region Insert into tournaments entries

            affectedRows = 0;
            foreach (TeamModel team in model.EnteredTeams) {
                sql = "INSERT INTO tournamententries (tournaments_id,teams_id) values(@tournamentid,@teamid)";
                affectedRows = affectedRows+ connection.Execute(sql, new { tournamentid = model.id, teamid = team.id });
            }
            //if entering into tournaments entries wasnt successfull
            if (affectedRows != model.EnteredTeams.Count)
            {
                //delete the tournament records too
                sql = "delete from tournaments where id=@id";
                var deleted = connection.Query<int>(sql, new { id =model.id }).Single();
                return model = null;
            }
            #endregion

            #region insert into tournament prizes

            affectedRows = 0;
            foreach (PrizeModel prize in model.Prizes)
            {
                sql = "INSERT INTO tournamentprizes (tournaments_id,prizes_id) values(@tournamentid,@prizeid)";
                affectedRows = affectedRows + connection.Execute(sql, new { tournamentid = model.id, prizeid = prize.id });
            }
            //if entering into tournaments entries wasnt successfull
            if (affectedRows != model.Prizes.Count)
            {
                //delete the tournament records too
                sql = "delete from tournaments where id=@id";
                var deleted = connection.Query<int>(sql, new { id = model.id }).Single();
                return model = null;
            }

            #endregion


            return model;
        }
    }
}
