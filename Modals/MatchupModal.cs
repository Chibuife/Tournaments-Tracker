using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary.Modals
{
   public class MatchupModal
    {
        public List<MatchupModal> MyProperty { get; set; } = new List<MatchupModal>();
        public TeamModal Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
