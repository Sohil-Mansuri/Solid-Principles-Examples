
namespace ISPExample.Solution
{
    internal class EmployeeCLevelFinance : IStockOption
    {
        public double CalculatePay(Employee employee)
        {
            return employee.TotalHoursWork * 200;
        }


        public double CalculateReward(Employee employee)
        {
            return 150;
        }

        public double CalculateStock(Employee employee)
        {
            return employee.Stocks + 10;
        }
    }
}
