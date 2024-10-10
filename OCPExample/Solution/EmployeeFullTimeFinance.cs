﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPExample.Solution
{
    internal class EmployeeFullTimeFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 10;
        }
    }
}
