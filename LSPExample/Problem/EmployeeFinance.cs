

namespace LSPExample.Problem
{
    /// <summary>
    /// We have added Reward method in Finance because its realted to Finance (cohesion)
    /// </summary>
    internal class EmployeeFinance
    {
        public virtual double CalculatePay(Employee employee)
        {
            return default;
        }

        public virtual double CalculateReward(Employee employee)
        {
            return default;
        }
    }
}
