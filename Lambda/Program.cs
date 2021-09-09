using System;

namespace ConsoleApplication22
{
    //lambda

    delegate void NiuDelegate(string name, int age);
    public class LambdaTest
    {

        public void Show()
        {
            NiuDelegate niuDelegate = new NiuDelegate(Niu);
            niuDelegate?.Invoke("God NIu",18);
            
            NiuDelegate niuDelegate2 = delegate(string name, int age)
            {
                Console.WriteLine($"2.我的名字是：{name},我的年纪是{age}");
            };
            niuDelegate2?.Invoke("GOd Niu",19);

            NiuDelegate niuDelegate3 = (name, age) =>
            {
                Console.WriteLine($"3.我的名字是：{name},我的年纪是{age}");
            };
            niuDelegate2?.Invoke("GOd Niu",20);
        }

        public void Niu(string name, int age)
        {
            Console.WriteLine($"1.我的名字是：{name},我的年纪是{age}");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}