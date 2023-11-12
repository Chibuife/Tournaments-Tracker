using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibary.Modals;

namespace TrackerLibary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModal CreatePrize(PrizeModal modal);
    }
}
