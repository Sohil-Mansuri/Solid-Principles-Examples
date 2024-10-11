
using SRPExample.Problem;

namespace SRPProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employ = new Employee();
            employ.Save(employ);

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
