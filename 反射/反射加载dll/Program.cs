using System;
using System.Reflection;
using ConsoleApplication11;

namespace ConsoleApplication10
{
    //反射加载dll
    internal class Program
    {
        public static void Main(string[] args)
        {
            Assembly assembly  = Assembly.LoadFrom("ConsoleApplication11.dll");
            
            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine(type.Name);  //类名

                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine(method.Name); //方法名
                }
            }

         
        }
    }
}