using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        ///     Reperesent two matchupEntry Models.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        ///     Represents who wins from these two
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        ///     Represent the matchupround number.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
