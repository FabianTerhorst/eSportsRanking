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
        public int winRatio
        {
            get {
                return winCount / Math.MAX(winCount + lossCount, gameCount);
            }
        }
        public int lossCount { get; set; }
        public int winCount { get; set; }
        public int gameCount
        { get
            {
                return lossCount + winCount;
            }
        }
    }
}
