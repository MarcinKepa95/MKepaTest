using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagmentSystemV2
{
    class Queen : Bee
    {
        private Worker[] Bees;
        private int shiftNumber = 0;

        public string WorktheNextShift()
        {
            double honeyconsumped = 0d;
            shiftNumber++;
            string Report = "Shift number #" + shiftNumber + "  Report: \r\n";
            for (int i = 0; i < Bees.Length; i++)
            {
                if (Bees[i].DidYouFinish())
                    Report += "Bee #" + (i + 1) + " Finished the job\r\n";
                else if (String.IsNullOrEmpty(Bees[i].CurrentJob))
                    Report += "Bee #" + (i + 1) + " is not working\r\n";
                else
                    if (Bees[i].ShiftsLeft > 0)
                    Report += "Bee " + (i + 1) + " Has " + Bees[i].ShiftsLeft + " Shifts left of work "
                        + Bees[i].CurrentJob + " \r\n";
                else
                    Report += "Bee #" + (i + 1) + " Finish " + Bees[i].CurrentJob + " after this shift\r\n";
                honeyconsumped += Bees[i].HoneyConsumptionRate();

            }
            honeyconsumped += HoneyConsumptionRate();
            Report += "Total honey consumed for the shift: " + honeyconsumped + " units\r\n";
            return Report;
        }

        public bool AssignWork(string Job, int shifts)
        {
            for (int i = 0; i < Bees.Length; i++)
                if (Bees[i].DoThisJob(Job, shifts))
                    return true;
            return false;
        }
        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            Bees = workers;
            shiftNumber = 0;
        }
    }
}
