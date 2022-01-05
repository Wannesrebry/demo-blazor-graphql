using shared.models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.models
{
    public  class ApplicationUser : BaseObject
    {

        public string Name { get; set; }
        public string Email { get; set; }  
      
        public List<Match> Matches
        {
            get
            {
                List<Match> tmp = new List<Match>();
                tmp.AddRange(MatchesAsPlayer1 ?? new List<Match>());
                tmp.AddRange(MatchesAsPlayer2 ?? new List<Match>());
                return tmp;
            }
        }
        public List<Match>? MatchesAsPlayer1 { get; set; }
        public List<Match>? MatchesAsPlayer2 { get; set; }
    }
}
