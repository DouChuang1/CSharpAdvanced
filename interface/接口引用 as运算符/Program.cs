using System;

namespace ConsoleApplication3
{
    //接口是引用类型

    interface IPrint
    {
        void PrintOut(string s);
    }

    interface ITestAs
    {
        void PrintOut(string s);
    }

    class MyClass : IPrint,ITestAs
    {
        public void PrintOut(string s)
        {
            Console.WriteLine(s);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyClass mc = new MyClass();  //创建类对象
            mc.PrintOut("object");       //调用类对象的实现方法

            IPrint ip = (IPrint) mc;    //将类对象的引用转换为接口类型的引用
            ip.PrintOut("interface");   //调用接口方法
            
            ITestAs it = mc as ITestAs;   //可以使用as运算符 进行转换
            if (it == null)
            {
                Console.WriteLine("NUll");
            }
            else
            {
                it.PrintOut("ITestAs"); 
            }
        }
    }
}