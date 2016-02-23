using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsRanking
{
    public class Team
    {
        public Team()
        {

        }

        public String name { get; set; }
        public int points { get; set; }
        public int lostGames { get; set; }
        public int wonGames { get; set; }
        public int gameCount
        { get
            {
                return lostGames + wonGames;
            }
        }
    }
}
