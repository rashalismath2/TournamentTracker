using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    /// <summary>
    ///  This allows us to implement in different connections.
    /// </summary>
    public interface IDataconnection
    {
        /// <summary>
        /// Used to store prizes in databse. Returns a Prize Model
        /// </summary>
        /// <param name="model">Takes a PrizeModel</param>
        /// <returns>PrizeModel just created from this method</returns>
        PrizeModel CreatePrize(PrizeModel model);

        /// <summary>
        /// Creates a new team member and store it in database
        /// </summary>
        /// <param name="model">Takse a PersonModel</param>
        /// <returns>Returns a Person Model</returns>
        PersonModel CreatePerson(PersonModel model);

        /// <summary>
        /// Pulls out all the people record in the database
        /// </summary>
        /// <returns>List of PersonModel</returns>
        List<PersonModel> GetAllPeople();

        /// <summary>
        /// Creates a New Team
        /// </summary>
        /// <param name="team">Gets a TeamModel Object</param>
        /// <returns>Added TeamModelobject</returns>
        TeamModel CreateTeam(TeamModel team);

        /// <summary>
        /// Getting all the team from the database
        /// </summary>
        /// <returns>Returns a list of teams</returns>
        List<TeamModel> GetAllTeam();

        /// <summary>
        /// Saving the torunament model into database
        /// </summary>
        /// <param name="model">Takes a tournament model</param>
        /// <returns>Returns a tournament model</returns>
        TournamentModel CreateTrounament(TournamentModel  model);
    }
}
