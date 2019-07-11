using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagmentSystemV2
{
    interface INectarCollector
    {
        void FindFlower();
        void GatherNectar();
        void ReturnToHive();
    }
}
