using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExample.Problem
{
    internal class EmployeeFinance
    {
        public double CalculatePay(Employee employee)
        {
            if(employee.Type == EmployeeType.FullTime.ToString())
            {
                return employee.TotalHoursWork * 10;
            }

            if (employee.Type == EmployeeType.PartTime.ToString())
            {
                return employee.TotalHoursWork * 5;
            }

            if (employee.Type == EmployeeType.Contract.ToString())
            {
                return employee.TotalHoursWork * 2;
            }

            return default;
        }
    }

}
