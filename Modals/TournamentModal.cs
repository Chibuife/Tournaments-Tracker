using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary.Modals
{
    public class TournamentModal
    {
        public string TornamentName { get; set; }

        public decimal EntryFee { get; set; }
        public List<TeamModal> EnterTeams { get; set; } = new List<TeamModal>();

        public List<PrizeModal> Prizes { get; set; } = new List<PrizeModal>();
        public List<List<MatchupModal>> Rounds { get; set; } = new List<List<MatchupModal>>();


    }
}
