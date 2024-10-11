

namespace ISPExample.Problem
{
    public interface IEmployeeFinance : IEmployeeReward
    {
        double CalculatePay(Employee employee);

        double CalculateStock(Employee employee);
    }
}
