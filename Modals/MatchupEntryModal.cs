using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary.Modals
{
    public class MatchupEntryModal
    {
        /// <summary>
        /// Represent one team in tornament
        /// </summary>
        public TeamModal TeamCompeting { get; set; }
        /// <summary>
        /// Represent the score of this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represent the matchup that this team came for as the winner
        /// </summary>
        public MatchupModal ParentMatch { get; set; }
    }
}
