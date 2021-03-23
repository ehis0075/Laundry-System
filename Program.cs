using System;

namespace SteveJobsLaundarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Laundry m = new Laundry();
            m.Wash("JEANS, T-SHIRTS", "PLS WASH MY CLOTHES");
            m.TakeTaxi(23);
        }
    }
}
