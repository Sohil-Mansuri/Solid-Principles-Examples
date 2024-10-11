

namespace OCPExample.Problem
{
    /// <summary>
    ///  here problme is if we keep getting new requirement then we need to update our exisitng code by adding new if check 
    ///  it violate OCP, it is open for modification
    ///  if we modify CalculatPay then we have to do all the testing again, and somtime we might break existing feature 
    ///  if we update existing code
    /// </summary>
    /// <remarks>
    /// we can modify our existing code when we get any bug, but if we get new requirement then we should not update exisitng code
    /// </remarks>
    internal class EmployeeFinance
    {
        public double CalculatePay(Employee employee)
        {
            if(employee.Type == EmployeeType.FullTime.ToString())
            {
                return employee.TotalHoursWork * 10;
            }

            if (employee.Type == EmployeeType.PartTime.ToString())
            {
                return employee.TotalHoursWork * 5;
            }

            if (employee.Type == EmployeeType.Contract.ToString())
            {
                return employee.TotalHoursWork * 2;
            }

            return default;
        }
    }

}
