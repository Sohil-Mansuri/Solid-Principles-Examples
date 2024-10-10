using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPExample.Solution
{
    internal class EmployeeFullTimeFinance : IEmployeeFinance
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 10;
        }

        public double CalculateReward(Employee employee)
        {
            return 200;
        }
    }
}
