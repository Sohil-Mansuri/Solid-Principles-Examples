
namespace ISPExample.AbstractionExample
{
    public interface IEmployeeFinance : IEmployeeReward
    {
        double CalculatePay(Employee employee);
    }
}
