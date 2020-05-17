using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class Program<T>
    {
        public void AddingNumbers(T value1, T value2)
        {
            dynamic d1 = value1;
            dynamic d2 = value2;
            Console.WriteLine(d1+d2);
        }
        public void subtractingNumbers(T value1, T value2)
        {
            dynamic d1 = value1;
            dynamic d2 = value2;
            Console.WriteLine(d1 - d2);
        }
        public void multiplicationNumbers(T value1, T value2)
        {
            dynamic d1 = value1;
            dynamic d2 = value2;
            Console.WriteLine(d1 * d2);
        }
        public void dividenNumbers(T value1, T value2)
        {
            dynamic d1 = value1;
            dynamic d2 = value2;
            Console.WriteLine(d1/d2);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Program<int> obj = new Program<int>();
            obj.AddingNumbers(10,10);
            obj.subtractingNumbers(40, 12);
            obj.multiplicationNumbers(8, 8);
            obj.dividenNumbers(10, 5);
            Console.ReadLine();

        }

    }
}
