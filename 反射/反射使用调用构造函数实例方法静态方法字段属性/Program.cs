using System;
using System.Reflection;
using ConsoleApplication11;

namespace ConsoleApplication12
{
    //通过反射创建对象 无参 有参 私有构造方法
    internal class Program
    {
        public static void Main(string[] args)
        {
            Assembly assembly  = Assembly.LoadFrom("ConsoleApplication11.dll");
            Type type = assembly.GetType("ConsoleApplication11.TestDll"); //获取类型 完整的类型名字
            
            //获取所有的构造方法 以及每个构造方法对应的参数
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                Console.WriteLine(ctor.Name);
                foreach (var param in ctor.GetParameters())
                {
                    Console.WriteLine(param);
                }
            }
            
            //object testObj = Activator.CreateInstance(type); //创建对象 调用无参构造方法
            //TestDll testDll = testObj as TestDll;

            object testObj2 = Activator.CreateInstance(type, new object[] {100}); //创建对象 调用有参数的构造函数
            TestDll testDll2 = testObj2 as TestDll;
            
            //单例模式会用到私有构造函数  这个也叫反射破坏单例
            object testObj3= Activator.CreateInstance(type,true); //创建对象 私有构造函数
            
            //反射调用方法 无参
            MethodInfo methodInfo = type.GetMethod("Show",new Type[]{});
            methodInfo.Invoke(testObj3, null);
            
            //反射调用方法 有参
            MethodInfo methodInfo2 = type.GetMethod("Show",new Type[]{typeof(string)});
            methodInfo2.Invoke(testObj3, new object[] {"KKKKKKKKKKKKK"});
            
            //静态
            MethodInfo methodInfo3 = type.GetMethod("StaticFunc");
            methodInfo3.Invoke(testObj3, null);
            
            //私有方法
            MethodInfo methodInfo4 = type.GetMethod("Show2",BindingFlags.Instance | BindingFlags.NonPublic);
            methodInfo4.Invoke(testObj3, new object[]{"私有实例方法"});
            
            //泛型方法
            var methodInfo5 = type.GetMethod("Show3").MakeGenericMethod(new Type[] {typeof(int)});
            methodInfo5.Invoke(testObj3, new object[] {100});

            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine(prop.Name);
                prop.SetValue(testObj3,5);
                Console.WriteLine(prop.GetValue(testObj3));
            }
                
            
        }
    }
}