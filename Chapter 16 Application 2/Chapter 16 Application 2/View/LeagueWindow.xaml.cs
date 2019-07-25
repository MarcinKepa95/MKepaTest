﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chapter_16_Application_2.View
{
    /// <summary>
    /// Logika interakcji dla klasy LeagueWindow.xaml
    /// </summary>
    public partial class LeagueWindow : Window
    {
        ViewModel.LeagueViewModel LeagueViewModel;
        public LeagueWindow()
        {
            InitializeComponent();
            LeagueViewModel = new ViewModel.LeagueViewModel();
        }

    }
}
