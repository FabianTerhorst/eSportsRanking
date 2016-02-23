using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSportsRanking
{
    public class Game
    {

        public Team winTeam { set; get; }
        public Team lossTeam { set; get; }

        public Game(Team winTeam, Team lossTeam)
        {
            this.winTeam = winTeam;
            this.lossTeam = lossTeam;
        }
    }
}
