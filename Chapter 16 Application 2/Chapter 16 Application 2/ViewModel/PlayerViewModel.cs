﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16_Application_2.ViewModel
{
    class PlayerViewModel
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public PlayerViewModel(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
