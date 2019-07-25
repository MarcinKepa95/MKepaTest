using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter_16_Application_2.Model;
using System.Collections.ObjectModel;
using System.Collections;
using System.ComponentModel;

namespace Chapter_16_Application_2.ViewModel
{
    class RosterViewModel
    {
        public ObservableCollection<PlayerViewModel> Starters { get; set; }
        public ObservableCollection<PlayerViewModel> Bench { get; set; }

        private Roster _roster;

        private string _teamName;
        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value;
                OnPropertyChanged("TeamName");
            }
        }

        private void UpdateRosters()
        {
            var startingPlayers = from player in _roster.players
                                  where player.Starter
                                  select player;
            Starters.Clear();
            foreach (Player player in startingPlayers)
                Starters.Add(new PlayerViewModel(player.Name, player.Number));

            var benchPlayers = from player in _roster.players
                                  where player.Starter == false
                                  select player;
            Bench.Clear();
            foreach (Player player in benchPlayers)
                Bench.Add(new PlayerViewModel(player.Name, player.Number));

        }

        public RosterViewModel(Roster roster)
        {
            _roster = roster;

            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();

            TeamName = _roster.TeamName;
            UpdateRosters();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
