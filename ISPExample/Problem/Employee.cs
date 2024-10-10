﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPExample.Problem
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;

        public string? Type { get; set; }

        public int TotalHoursWork { get; set; }

        public int Stocks { get;set; }  

    }

    public enum EmployeeType
    {
        FullTime,
        PartTime,
        Contract,
        CLevel
    }
}
