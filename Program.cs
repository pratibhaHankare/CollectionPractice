using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            bool result = obj.comapre<float>(22.6f,22.7f);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        public bool comapre<T>(T value1,T value2)
        {
            if (value1.Equals(value2))
                return true;
            return false;
        }
    }
}
