using System;

namespace CSharp
{
    public abstract class Customer
    {
        public string name;
        public string id;
        public DateTime dateBill;
        public int qty;
        public double money;
        public double Limit(double a)
        {
            int m = 0;
            if (a < 50)
            {
                m = 1000;
            }

            if (a >= 50 && a <100)
            {
                m = 1200;
            }

            if (a >= 100 && a < 200)
            {
                m = 1500;
            }

            if (a > 200)
            {
                m = 2000;
            }

            return m;
        }
    }
}