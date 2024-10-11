

namespace ISPExample.Solution
{
    internal class EmployeeFullTimeFinance : IEmployeeFinance
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 10;
        }

        public double CalculateReward(Employee employee)
        {
            return 200;
        }
    }
}
