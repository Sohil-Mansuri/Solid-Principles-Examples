

namespace LSPExample.Solution
{
    internal class EmployeeFullTimeFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 10;
        }

        public override double CalculateReward(Employee employee)
        {
            return 200;
        }
    }
}
