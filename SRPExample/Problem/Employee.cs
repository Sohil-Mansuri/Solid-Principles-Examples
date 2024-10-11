

namespace SRPExample.Problem
{
    /// <summary>
    /// It is violating SRP
    /// </summary>
    /// <example>
    /// As you can see it is managed by 3 people
    /// and it has three reason to change 
    /// </example>
    public class Employee
    {
        /// <summary>
        /// Managed by CFO (chief Finanace Officer)
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public double CalculatePay(Employee emp)
        {
            return default;
        }

        /// <summary>
        /// Managed by CTO (Chief Technical Officer)
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public bool Save(Employee emp)
        {
            try
            {
                //Save into DB 
                //throw new Exception();
                return true;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("D:\\logs.txt", ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Managed by COO (chief Operation Officer)
        /// </summary>
        /// <param name="emp"></param>
        public void ReportHours(Employee emp)
        {

        }
    }
}
