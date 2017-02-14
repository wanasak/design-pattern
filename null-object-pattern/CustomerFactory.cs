using System;

namespace null_object_pattern
{
    public class CustomerFactory
    {
        public static readonly string[] names = { "Rob", "Joe", "Julie" };
        public static AbstrctCustomer getCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                    return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }
}