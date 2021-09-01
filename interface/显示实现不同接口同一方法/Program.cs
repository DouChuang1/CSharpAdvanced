using System;

namespace ConsoleApplication4
{
    interface IIfc1
    {
        void PrintOut(string s);
    }
    
    interface IIfc2
    {
        void PrintOut(string s);
    }

    class MyClass : IIfc1, IIfc2
    {
        void IIfc1.PrintOut(string s)
        {
            Console.WriteLine("iffc1"+s);
        }
        
        void IIfc2.PrintOut(string s)
        {
            Console.WriteLine("iffc2"+s);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            
            IIfc1 if1 = mc as IIfc1;
            if1.PrintOut("interface 1");
            
            IIfc2 if2 = mc as IIfc2;
            if2.PrintOut("interface 2");
        }
    }
}