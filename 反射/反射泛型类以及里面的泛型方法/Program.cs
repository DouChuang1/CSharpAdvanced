using System;
using System.Reflection;
using ConsoleApplication13;

namespace ConsoleApplication14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Assembly assembly  = Assembly.LoadFrom("ConsoleApplication13.dll");
            Type type = assembly.GetType("ConsoleApplication13.GenericClass`3"); //获取类型 完整的类型名字

            Type makeType = type.MakeGenericType(new Type[] {typeof(int), typeof(int), typeof(int)});
            object testObj = Activator.CreateInstance(makeType); //创建泛型类对象

            MethodInfo methodInfo = makeType.GetMethod("Test");
            var method = methodInfo.MakeGenericMethod(new Type[] {typeof(int), typeof(int), typeof(int)});

            method.Invoke(testObj, new object[] {5,6,7});
        }
    }
}