using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagmentSystemV2
{
    class Worker : Bee
    {
        private string currentJob = "";

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return ShiftToWork - shiftsWorked;
            }
        }

        private string[] JobsICanDo;
        private int ShiftToWork;
        private int shiftsWorked;

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked <= ShiftToWork)
                return false;

            shiftsWorked = 0;
            ShiftToWork = 0;
            currentJob = "";
            return true;
        }

        public bool DoThisJob(string job, int shifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            if (JobsICanDo.Contains<string>(job))
            {
                currentJob = job;
                ShiftToWork = shifts;
                shiftsWorked = 0;
                return true;
            }
            return false;
        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate() + shiftsWorked * HoneyUnitsConsumedPerMg;
        }
        public Worker(string[] WorkerJob, double weightMg) : base(weightMg)
        {
            JobsICanDo = WorkerJob;
        }
    }
}
