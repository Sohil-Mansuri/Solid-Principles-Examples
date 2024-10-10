using Unity;

namespace DIPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, FileLogger>();
            container.RegisterType<ILogger, DBLogger>();

            var employee = container.Resolve<Employee>();
            employee.Save(employee);

            Console.ReadKey();
        }
    }
}
