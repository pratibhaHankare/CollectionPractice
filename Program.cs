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
            testCustomer test = new testCustomer();
            test.custInfoadding();
            Console.ReadLine();
        }
    }

    class Customers
    {
        public int custId { set; get; }
        public string custName { set; get; }
        public string custEmail { set; get; }
        public double custBal { set; get; }
        public string custLocation { set; get; }
    }

    class testCustomer
    {
        public void custInfoadding()
        {
            Customers c1 = new Customers
            {
                custId = 1,
                custName = "abc",
                custEmail = "a@something.com",
                custBal = 1000.56,
                custLocation = "Pune"
            };
            Customers c2 = new Customers
            {
                custId = 2,
                custName = "abc",
                custEmail = "a@something.com",
                custBal = 1000.56,
                custLocation = "Pune"
            };
            Customers c3 = new Customers
            {
                custId = 3,
                custName = "abc",
                custEmail = "c@something.com",
                custBal = 1090.56,
                custLocation = "Pune"
            };
            List<Customers> Customer = new List<Customers>();
            Customer.Add(c1);
            Customer.Add(c2);
            Customer.Add(c3);
            // printing values
            foreach (Customers cust in Customer)
            {
                Console.WriteLine(cust.custId+" "+cust.custName + " " +cust.custEmail + " " +cust.custLocation + " " +cust.custBal);
            }
        }


    }
}
