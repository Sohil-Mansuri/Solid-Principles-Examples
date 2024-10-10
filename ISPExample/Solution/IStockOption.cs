using ISPExample.AbstractionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPExample.Solution
{
    internal interface IStockOption : IEmployeeFinance
    {
        double CalculateStock(Employee employee);
    }
}
