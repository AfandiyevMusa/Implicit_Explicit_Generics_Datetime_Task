using System;
namespace Implicit_Explicit_Generics_Datetime_HW.HW
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private DateTime Birthday { get; set; }
        public double Salary { get; set; }

        public Employee(DateTime birthday, double salary)
        {
            Birthday = birthday;
            Salary = salary;
        }

        public static int cnt = 0;

        public bool CheckInfo(DateTime start, DateTime end, int a = 2000)
        {
            if ((Birthday > start && Birthday < end) && Salary > a)
            {
                cnt++;
                return true;
            }
            return false;
        }
    }
}

