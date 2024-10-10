

namespace SRPExample.Solution
{
    /// <summary>
    /// Will be handeld be CTO 
    /// </summary>
    public class Employee
    {
        public bool Save(Employee emp)
        {
            try
            {
                //Save into DB 
                return true;
            }
            catch (Exception ex)
            {

                // this is not correct to tightely couple with Logger Class it will be handle through DI later on
                // we should avoid creating object with new keyword, becuase it get tightely coupled 
                Loggger log = new();
                log.LogError(ex.Message);

                return false;
            }
        }
    }
}
