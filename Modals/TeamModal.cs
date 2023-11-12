using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibary.Modals
{
    public class TeamModal
    {
        public List<PersonModal> TeamMembers { get; set; } = new List<PersonModal>(); 
        public string TeamName { get; set; }
    }
}
