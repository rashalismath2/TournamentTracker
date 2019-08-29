using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
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
        public double PrizePrecentage { get; set; }
    }
}
