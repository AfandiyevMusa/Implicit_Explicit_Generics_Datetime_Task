using System;
namespace Implicit_Explicit_Generics_Datetime_HW.Models
{
    public class DataList<T>
    {
        private T[] _arr;

        public DataList()
        {
            _arr = new T[0];
        }

        public void Add(T vary)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = vary;
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

