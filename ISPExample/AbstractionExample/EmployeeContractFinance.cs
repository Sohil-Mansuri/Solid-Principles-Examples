
namespace ISPExample.AbstractionExample
{
    internal class EmployeeContractFinance : IEmployeeReward
    {
        public double CalculateReward(Employee employee)
        {
            return 120;
        }
    }
}
