using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class SingleObject
    {
        // create an object of single object
        private static SingleObject instance = new SingleObject();
        // make the constructor private so that class cannot be instantiated
        private SingleObject() {} 
        // get the only object avaiable
        public static SingleObject GetInstance()
        {
            return instance;
        }
        public void ShowMessage()
        {
            Console.WriteLine("Hello World.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // SingleObject obj = new SingleObject();
            SingleObject obj = SingleObject.GetInstance();
            obj.ShowMessage();
        }
    }
}
