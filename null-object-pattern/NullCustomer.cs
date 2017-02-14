using System;

namespace null_object_pattern
{
    public class NullCustomer : AbstrctCustomer
    {
        public override string getName()
        {
            return "Not available in database";
        }

        public override bool isNull()
        {
            return true;
        }
    }
}