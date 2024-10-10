using OCPExample.Solution;

namespace OCPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fulltimeEmp = new Employee
            {
                Name = "Sohil",
                TotalHoursWork = 10,
                Type = EmployeeType.FullTime.ToString(),
            };

            var partTimeEmp = new Employee
            {
                Name = "Mithil",
                TotalHoursWork = 10,
                Type = EmployeeType.PartTime.ToString(),
            };

            var contractEmp = new Employee
            {
                Name = "DK",
                TotalHoursWork = 10,
                Type = EmployeeType.Contract.ToString(),
            };

            EmployeeFinance empFinance = new EmployeeFullTimeFinance();
            //EmployeeFinance empFinance = new EmployeePartTimeFinance();
            //EmployeeFinance empFinance = new EmployeeContractFinance();

            Console.WriteLine($"Total pay of is {empFinance.CalculatePay(fulltimeEmp)}");

            Console.ReadKey();

        }
    }
}
