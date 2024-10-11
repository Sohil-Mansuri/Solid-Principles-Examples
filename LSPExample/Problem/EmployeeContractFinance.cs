

namespace LSPExample.Problem
{
    /// <summary>
    /// You can see problem here, now EmployeeContractFinance is not replacable by BaseClass EmployeeFinance
    /// so Its Not follwing LSP
    /// please check in solution section, How it is solved 
    /// </summary>
    internal class EmployeeContractFinance : EmployeeFinance
    {
        public override double CalculatePay(Employee employee)
        {
            // Because for contractor employee Payroll handled by Vendor company
            throw new NotImplementedException();
        }

        public override double CalculateReward(Employee employee)
        {
            return 120;
        }
    }
}
