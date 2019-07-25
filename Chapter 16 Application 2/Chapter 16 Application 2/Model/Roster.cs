using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16_Application_2.Model
{
    class Roster
    {
        public string TeamName { get; private set; }

        private readonly List<Player> _players = new List<Player>();

        public IEnumerable<Player> players
        {
            get { return new List<Player>(_players); }
        }

        public Roster(string teamName, IEnumerable<Player> players)
        {
            TeamName = teamName;
            _players.AddRange(players);
        }
    }
}
