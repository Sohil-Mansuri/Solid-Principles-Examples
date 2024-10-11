

namespace LSPExample.Solution
{
    /// <summary>
    /// As you can see here how Contract Employee can get only reward
    /// </summary>
    internal class EmployeeContractFinance : EmployeeReward
    {
        public override double CalculateReward(Employee employee)
        {
            return 120;
        }
    }
}
