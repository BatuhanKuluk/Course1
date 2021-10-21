using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var City = new List<string>();
            City.Add("Adana");
            City.Add("Adana");
            City.Add("Adana");
            City.Add("Adana");
            City.Add("Adana");
            City[1] = "İstanbul";
            Console.WriteLine(City.Count);
            Console.WriteLine(City[1]);
            foreach (var cityy in City)
            {
                Console.WriteLine(cityy);
            }

            var City2 = new MyList<string>();
            City2.Add("İstanbul");
            City2.Add("İstanbul");
            City2.Add("İstanbul");
            City2.Add("İstanbul");
            City2.Add("İstanbul");
            City2[1] = "Adana";
            Console.WriteLine(City2.Count);
            Console.WriteLine(City2[1]);
            foreach (var cityy in City2.Items)
            {
                Console.WriteLine(cityy);
            }

        }
    }
    public class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }

        }

        public T[] Items { get { return _array; } }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

    }
}
