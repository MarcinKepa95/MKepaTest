using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagmentSystemV2
{
    class Bee
    {
        protected const double HoneyUnitsConsumedPerMg = 0.25d;

        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            this.WeightMg = weightMg;
        }
        public virtual double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
