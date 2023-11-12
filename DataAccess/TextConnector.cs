using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibary.Modals;

namespace TrackerLibary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files. 
        public PrizeModal CreatePrize(PrizeModal modal)
        {
            modal.Id = 1;
            return modal;
        }
    }
}
