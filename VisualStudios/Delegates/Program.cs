using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Func();
        public static int count;
        static void PrintName()
        {
            count++;
            Console.WriteLine("count: " + count);
        }

        static void Main(string[] args)
        {
            Func myFunction = new Func(PrintName);

            myFunction += PrintName;
            myFunction += PrintName;
            myFunction += PrintName;
            myFunction += PrintName;
            myFunction += PrintName;


            myFunction.Invoke();

            Console.ReadLine();
        }

    }
}
