

namespace OCPExample.Solution
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;

        public string? Type { get; set; }

        public int TotalHoursWork { get; set; }

    }

    public enum EmployeeType
    {
        FullTime,
        PartTime,
        Contract
    }
}
