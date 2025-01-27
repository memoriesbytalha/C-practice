using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using C__Practice;
using MyApp.Orders;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderHelper.MyMethod();

            Console.WriteLine("Hello Niggac!");
            Console.WriteLine(3 + 3);   
            var name = "Talha Ali Panda";
            int num = 14;
            Console.WriteLine("{0} {1}",Name,num);
            const int pi = 3;
            Console.WriteLine($"{pi} {Name} {num}");


            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble); 


            Console.WriteLine("Writre your name");
            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username);
            int x = 6;
            Console.WriteLine(x|=3);
            int x = 5;
            int y = 3;
            Console.WriteLine(x < y); // returns True because 5 is greater than 3
            Console.WriteLine(name.ToLower());

            string last_name = name.Substring(0, 4);
            Console.WriteLine(last_name);

            int time = 20;
            string result = (time < 24) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            int day = 10;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            name = "Talha";
            int i = 0;
            do
            {
                Console.WriteLine(name);
                i++;
            } while (i < 6);
            for (int i =0; i < 5;i++ )
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {   
                    Console.WriteLine(name);
                    continue;
                }
                Console.WriteLine(i);
            }
            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    Console.WriteLine(name);
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }

            string[] cars; // Declare an array of strings




            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i + "\t" + "Bambooo");

            }

            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            Console.WriteLine(string.Join(',',myNumbers));  // Outputs 1
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());


        }

    }

}
                                             