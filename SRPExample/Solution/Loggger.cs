

namespace SRPExample.Solution
{
    public class Loggger
    {
        /// <summary>
        /// if logging logic changes then you just need to update here 
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            System.IO.File.WriteAllText("D:\\logs.txt", message);
        }
    }
}
