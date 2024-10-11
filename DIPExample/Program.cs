using Unity;

namespace DIPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var container = RegisterServices();
            var employee = container.Resolve<Employee>();
            employee.Save(employee);

            Console.ReadKey();
        }

        public static IUnityContainer RegisterServices()
        {
            //This config should come from appSetting but for simplitcy i have added here 
            bool isFileLoggingEnabled = false;

            IUnityContainer container = new UnityContainer();
            if (isFileLoggingEnabled)
                container.RegisterType<ILogger, FileLogger>();
            else
                container.RegisterType<ILogger, DBLogger>();

            return container;
        }
    }
}
