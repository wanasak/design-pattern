using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace null_object_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstrctCustomer customer1 = CustomerFactory.getCustomer("Peter");
            AbstrctCustomer customer2 = CustomerFactory.getCustomer("Rob");
            AbstrctCustomer customer3 = CustomerFactory.getCustomer("Julie");

            Console.WriteLine(customer1.getName());
            Console.WriteLine(customer2.getName());
            Console.WriteLine(customer3.getName());
        }
    }
}
