using System;
namespace Implicit_Explicit_Generics_Datetime_HW.Models
{
    public class StringList
    {
        private string[] _arr;

        public StringList()
        {
            _arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = str;
        }

        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}

