

namespace DIPExample
{
    internal class Employee(ILogger logger)
    {
        public bool Save(Employee emp)
        {
            try
            {
                //Save into DB 
                //return true;
                throw new Exception();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return false;
            }
        }
    }
}
