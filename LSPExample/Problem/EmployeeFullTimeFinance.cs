using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExample.Problem
{
    internal class EmployeeFullTimeFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 10;
        }

        public override double CalculateReward(Employee employee)
        {
            return 200;
        }
    }
}
