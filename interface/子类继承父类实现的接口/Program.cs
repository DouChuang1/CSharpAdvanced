using System;

namespace ConsoleApplication2
{
    interface IIfc1
    {
        void PrintOut(string s);
    }

    class MyBaseClass
    {
        public void PrintOut(string s)
        {
            Console.WriteLine($"Calling through: {s}");
        }
    }

    class Derived : MyBaseClass, IIfc1
    {
        
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Derived d = new Derived();
            d.PrintOut("object");
        }
    }
}