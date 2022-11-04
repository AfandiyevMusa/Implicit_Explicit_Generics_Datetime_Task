using System;
using System.Collections.Generic;
using System.Drawing;
using Implicit_Explicit_Generics_Datetime_HW.HW;
using Implicit_Explicit_Generics_Datetime_HW.Models;

namespace Implicit_Explicit_Generics_Datetime_HW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Task_1
            //Kelvin kelvin = new Kelvin(274);
            //Celsius celsius = kelvin;
            //Console.WriteLine(celsius.Degree);
            #endregion

            #region Implicit_Explicit_DateTime
            //Manat manat = new Manat(170);
            //Dollar dollar = manat;
            //Console.WriteLine(dollar.Usd);

            //DateTime date1 = DateTime.Now;
            //Console.WriteLine(date1);

            //DateTime date2 = DateTime.UtcNow;
            //Console.WriteLine(date2);
            #endregion

            #region Without Generic
            //StringList list = new StringList();

            //list.Add("First");
            //list.Add("Second");
            //list.Add("Third");

            //list.GetAll();

            //IntList nums = new IntList();

            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);

            //nums.GetAll();
            #endregion

            #region With Generic
            //DataList<int> nums1 = new DataList<int>();

            //nums1.Add(1);
            //nums1.Add(2);
            //nums1.Add(3);

            //nums1.GetAll();

            //DataList<string> list1 = new DataList<string>();

            //list1.Add("First");
            //list1.Add("Second");
            //list1.Add("Third");

            //list.GetAll();
            #endregion

            //Repository<int> num = new Repository<int>();
            //Repository<string> name = new Repository<string>();
            //Repository<Student> student = new Repository<Student>();

            #region Task_3

            Employee employee1 = new Employee(DateTime.Parse("05 / 05 / 2020"), 2020);
            Employee employee2 = new Employee(DateTime.Parse("02 / 06 / 2021"), 1900);
            Employee employee3 = new Employee(DateTime.Parse("01 / 03 / 2017"), 2001);
            Employee employee4 = new Employee(DateTime.Parse("05 / 05 / 2019"), 2003);
            Employee employee5 = new Employee(DateTime.Parse("05 / 05 / 2010"), 4000);

            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };

            int count = 0;

            foreach (var item in employees)
            {
                bool ifIsTrue = item.CheckInfo(DateTime.Parse("05/05/2018"), DateTime.Parse("05/05/2021"));
                if (ifIsTrue)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            #endregion


        }
    }

}