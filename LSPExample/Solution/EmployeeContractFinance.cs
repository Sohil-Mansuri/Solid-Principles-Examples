using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExample.Solution
{
    internal class EmployeeContractFinance : EmployeeReward
    {
        public override double CalculateReward(Employee employee)
        {
            return 120;
        }
    }
}
