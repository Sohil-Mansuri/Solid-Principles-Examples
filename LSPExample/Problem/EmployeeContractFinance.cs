using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExample.Problem
{
    internal class EmployeeContractFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            // Because for contractor employee Payroll handled by Vendor company
            throw new NotImplementedException();
        }

        public override double CalculateReward(Employee employee)
        {
            return 120;
        }
    }
}
