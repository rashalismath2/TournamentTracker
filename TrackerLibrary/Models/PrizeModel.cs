using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        ///   Give the id of a prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///     Reperesent the palace by as a number
        /// </summary>
        public int PlaceNUmber { get; set; }

        /// <summary>
        ///    Represent the palce as a string
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        ///    Represent the prize amount for this place
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        ///     represent the precentage of prize from the tournament prize.
        /// </summary>
        public int PrizePrecentage { get; set; }
    }
}
