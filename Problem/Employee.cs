using SRPExample.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPExample.Problem
{
    public class Employee
    {
        public double CalculatePay(Employee emp)
        {
            return default;
        }

        public bool Save(Employee emp)
        {
            try
            {
                //Save into DB 
                return true;

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("D://logs.txt", ex.Message);
                return false;
            }
        }


        public void ReportHours(Employee emp)
        {

        }
    }
}
