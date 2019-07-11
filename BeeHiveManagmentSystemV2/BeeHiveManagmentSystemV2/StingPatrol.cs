using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagmentSystemV2
{
    class StingPatrol : Worker, IStingPatrol, INectarCollector
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int Length)
        {
            return 1;
        }
        public void FindFlower()
        {

        }

        public void GatherNectar()
        {

        }

        public void ReturnToHive()
        {

        }
    }
}
