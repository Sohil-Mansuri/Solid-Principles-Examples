

namespace OCPExample.Solution
{
    internal class EmployeePartTimeFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 5;
        }
    }
}
