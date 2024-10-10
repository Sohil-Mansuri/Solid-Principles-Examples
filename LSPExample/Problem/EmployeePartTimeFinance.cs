using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExample.Problem
{
    internal class EmployeePartTimeFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 5;
        }

        public override double CalculateReward(Employee employee)
        {
            return 150;
        }
    }
}
