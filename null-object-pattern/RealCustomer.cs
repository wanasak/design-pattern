using System;

namespace null_object_pattern
{
    public class RealCustomer : AbstrctCustomer
    {
        public RealCustomer(string name)
        {
            this.Name = name;
        }

        public override string getName()
        {
            return this.Name;
        }

        public override bool isNull()
        {
            return false;
        }
    }
}