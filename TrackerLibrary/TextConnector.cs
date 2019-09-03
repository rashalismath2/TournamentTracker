using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    ///     Implelements IDataconnection interface to save model in text files
    /// </summary>
    public class TextConnector : IDataconnection
    {
        //TODO - Write logics for save prize model in textfile
        public PrizeModel CreatePrize(PrizeModel model)
        {
           return model;
        }
    }
}
