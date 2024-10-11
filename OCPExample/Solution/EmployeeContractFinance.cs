

namespace OCPExample.Solution
{
    internal class EmployeeContractFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 2;
        }
    }
}
