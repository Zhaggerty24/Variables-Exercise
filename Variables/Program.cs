using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Zach";
            int myAge = 27;
            
            Console.WriteLine("My name is " + myName + " I am " + myAge + " years old");
            Console.ReadLine();

            double dval = 100.0d / 3;
            Console.WriteLine(dval);

            decimal dval2 = 100.0M / 3;
            Console.WriteLine(dval2);

            char chr = 'S';
            Console.WriteLine("chr: " + chr);
            Console.WriteLine("Size of char variable: " + sizeof(char));

            bool isBasketballFun = true;
            bool isBrusselSproutstatsy = false;
            Console.WriteLine(isBasketballFun);
            Console.WriteLine(isBrusselSproutstatsy);
            
          
            
        }
    }
}
