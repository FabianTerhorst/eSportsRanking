using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsRanking
{
    public class Team
    {
        public Team(String name)
        {
            this.name = name;
        }

        public String name { get; set; }
        public double winRatio
        {
            get {
                return winCount /(winCount + lossCount)*100;
            }
        }
        public double lossCount { get; set; }
        public double winCount { get; set; }
        public double gameCount
        { get
            {
                return lossCount + winCount;
            }
        }
    }
}
