using System;

namespace ConsoleApplication17
{
    //委托是一个引用类型 是一个类 保存方法的指针 指向一个方法 调用委托的时候方法就立即执行
    internal class Program
    {
        delegate void NiuDelegate(string msg);
        public static void Main(string[] args)
        {
            NiuDelegate niuDelegate = delegate(string msg) { Console.WriteLine(msg); };
            niuDelegate("NIU");
        }

     
    }
}