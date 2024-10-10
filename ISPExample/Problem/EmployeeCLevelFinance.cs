using ISPExample.AbstractionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPExample.Problem
{
    internal class EmployeeCLevelFinance : IEmployeeFinance
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 200;
        }

        public double CalculateReward(Employee employee)
        {
            return 150;
        }

        public double CalculateStock(Employee employee)
        {
            return employee.Stocks + 10;
        }
    }
}
