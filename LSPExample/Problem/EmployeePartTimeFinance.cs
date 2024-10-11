
namespace LSPExample.Problem
{
    internal class EmployeePartTimeFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 5;
        }

        public override double CalculateReward(Employee employee)
        {
            return 150;
        }
    }
}
