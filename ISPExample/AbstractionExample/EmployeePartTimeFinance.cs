

namespace ISPExample.AbstractionExample
{
    internal class EmployeePartTimeFinance : IEmployeeFinance
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 5;
        }

        public double CalculateReward(Employee employee)
        {
            return 150;
        }
    }
}
