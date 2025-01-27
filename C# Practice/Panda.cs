using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Panda
{
    public class Panda
    {

        public static void MyMethod(string fname = "Pakistan ")
        {
            Console.WriteLine(fname + " Shaba");
        }

        public static int Mysum(int x)
        {
            return x + 5;
        }

        public static string Names(string child1 , string child2)
        {
            return child1 + child2;
        }
    }
}

