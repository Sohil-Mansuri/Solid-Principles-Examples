

namespace ISPExample.Solution
{
    public interface IEmployeeFinance : IEmployeeReward
    {
        double CalculatePay(Employee employee);
    }
}
