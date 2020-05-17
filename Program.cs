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
            Dictionary<string,object> dt = new Dictionary<string, object>();
            dt.Add("eId",1);
            dt.Add("ename","pratibha");
            dt.Add("mgnrId",1111);
            dt.Add("eemail","e@something.com");
            dt.Add("elocation","pune");
            dt.Add("degination","TA");
            foreach(string key in dt.Keys){
                Console.WriteLine(key +" : "+dt[key]);
            }
            Console.ReadLine();
        }

    }
}
