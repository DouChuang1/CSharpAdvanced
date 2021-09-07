using System;

namespace ConsoleApplication6
{
    //自定义泛型类
    class GenericClass<T>
    {
        private T t;

        public GenericClass(T t)
        {
            this.t = t;
        }

        public void SetValue(T t1)
        {
            t = t1;
        }

        public T GetValue()
        {
            return t;
        }
    }
    internal class Program
    {
        //自定义泛型方法
        public static void Show<T>(T t)
        {
            Console.WriteLine(t.ToString());
        }
        
        public static void Main(string[] args)
        {
            GenericClass<int> gc = new GenericClass<int>(100);

            int ret = gc.GetValue();
            Show<string>("Hello GenericFunction");
            Console.WriteLine(ret);
            Console.Read();
        }
    }
}