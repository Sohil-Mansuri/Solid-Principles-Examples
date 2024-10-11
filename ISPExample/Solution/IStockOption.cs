

namespace ISPExample.Solution
{
    internal interface IStockOption : IEmployeeFinance
    {
        double CalculateStock(Employee employee);
    }
}
