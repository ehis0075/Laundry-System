using System;

namespace SteveJobsLaundarySystem
{

    class Laundry
    {

          private string lanaguage { get; set; }

          private int money {set; get; }
 
        public string Wash(String dirtyClothes, string message)
        {
            if(dirtyClothes != null && message != null) {
             System.Console.WriteLine("washing clothes.........");
            }
             return " Here are your clean clothes.";
        }

        public string TakeTaxi(int money)
        {
            if(money > 0)
            {
                 System.Console.WriteLine("taking taxi...........");
            }
           
           
            return "ok...";
        }
    }
}
