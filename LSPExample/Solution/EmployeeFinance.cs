﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPExample.Solution
{
    internal class EmployeeFinance : EmployeeReward
    {
        public virtual double CalculatePay(Employee employee)
        {
            return default;
        }
    }
}