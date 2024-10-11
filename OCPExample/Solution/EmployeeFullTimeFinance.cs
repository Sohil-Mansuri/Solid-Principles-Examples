
namespace OCPExample.Solution
{
    internal class EmployeeFullTimeFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 10;
        }
    }
}
