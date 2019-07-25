using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter_16_Application_2.Model;
using System.Collections.ObjectModel;

namespace Chapter_16_Application_2.ViewModel
{
    class LeagueViewModel
    {
        public RosterViewModel BriansTeam { get; set; }
        public RosterViewModel JimmysTeam { get; set; }

        public LeagueViewModel()
        {
            Roster briansRoster = new Roster("The Bombers", GetBomberPlayers());
            Roster JimmysRoster = new Roster("The Amazins", GetAmazinPlayers());

            BriansTeam = new RosterViewModel(briansRoster);
            JimmysTeam = new RosterViewModel(JimmysRoster);
        }
        private IEnumerable<Player> GetBomberPlayers()
        {
            List<Player> bomberPlayers = new List<Player>() {
             new Player("Brian", 31, true),
             new Player("Lloyd", 23, true),
             new Player("Kathleen",6, true),
             new Player("Mike", 0, true),
             new Player("Joe", 42, true),
             new Player("Herb",32, false),
             new Player("Fingers",8, false),
             };
            return bomberPlayers;
        }
        private IEnumerable<Player> GetAmazinPlayers()
        {
            List<Player> amazinPlayers = new List<Player>() {
             new Player("Jimmy",42, true),
             new Player("Henry",11, true),
             new Player("Bob",4, true),
             new Player("Lucinda", 18, true),
             new Player("Kim", 16, true),
             new Player("Bertha", 23, false),
             new Player("Ed",21, false),
             };
            return amazinPlayers;
        }
    }
}
