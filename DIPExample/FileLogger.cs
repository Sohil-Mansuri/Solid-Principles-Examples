

namespace DIPExample
{
    internal class FileLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("Logged in File {0}", message);
        }
    }
}
