using System;

namespace ConsoleApplication18
{
    //泛型委托
    internal class Program
    {
        delegate void GenericDelegate<T>(T t);
        public class GenericDelegateClass
        {
            public static void InvokeDelegate()
            {
                GenericDelegate<string> genericDelegate = delegate(string s)
                {
                    Console.WriteLine(s);
                };
                
                genericDelegate.Invoke("NIu God");
                
                //不带返回值委托
                Action<string> action = delegate(string s)
                {
                    Console.WriteLine(s);
                };
                action.Invoke("官方版本");
                
                //带返回值委托
                Func<string,string> func = delegate(string s)
                {
                    return s;
                };

                string str = func.Invoke("带返回值委托");
                Console.WriteLine(str);
            }
        }
        public static void Main(string[] args)
        {
            GenericDelegateClass.InvokeDelegate();
        }
    }
}