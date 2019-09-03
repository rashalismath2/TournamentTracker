using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{   
    /// <summary>
    ///     Implelements IDataConnection Interface to add data into sql database
    /// </summary>
    public class SqlConnector : IDataconnection
    {
        //TODo - add logics to save prize model into the database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            return model;
        }
    }
}
