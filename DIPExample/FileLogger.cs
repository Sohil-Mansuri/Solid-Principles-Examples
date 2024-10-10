using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
