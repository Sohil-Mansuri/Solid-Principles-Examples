

namespace DIPExample
{
    internal class DBLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("Logged in DB {0}", message);
        }
    }
}
