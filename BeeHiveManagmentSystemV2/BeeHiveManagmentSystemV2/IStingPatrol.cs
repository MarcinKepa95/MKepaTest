﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagmentSystemV2
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int Length);
    }
}
