using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
