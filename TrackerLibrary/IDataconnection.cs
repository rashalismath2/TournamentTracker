using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
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
    }
}
