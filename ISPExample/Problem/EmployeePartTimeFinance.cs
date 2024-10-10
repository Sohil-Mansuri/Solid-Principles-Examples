using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPExample.Problem
{
    internal class EmployeePartTimeFinance : IEmployeeFinance
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 5;
        }

        public double CalculateReward(Employee employee)
        {
            return 150;
        }

        public double CalculateStock(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
