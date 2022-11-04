using System;
namespace Implicit_Explicit_Generics_Datetime_HW.Models
{
    public class IntList
    {
        private int[] _arr;

        public IntList()
        {
            _arr = new int[0];
        }

        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
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

