using System;

namespace ConsoleApplication13
{
    public class GenericClass<T,K,W>
    {
        public GenericClass()
        {
            Console.WriteLine("创建对象");
        }

        public void Test<A, B, C>(A t, B k, C w)
        {
            Console.WriteLine(t.ToString()+k.ToString()+w.ToString());
        }
    }
}