using System;

namespace ConsoleApplication11
{
    public class TestDll
    {
        private TestDll()
        {
            Console.WriteLine("私有构造");
        }
        //public TestDll()
        //{
        //    Console.WriteLine("创建对象 无参");
        //}
        
        public TestDll(int index)
        {
            Console.WriteLine("创建对象 有参");
            this.index = index;
        }
        
        public static void StaticFunc()
        {
            Console.WriteLine("StaticFunc");
        }

        private int index;

        public int Index
        {
            set => index = value;
            get => index;
        }

        public void Show()
        {
            Console.WriteLine(index.ToString());
        }
        
        public void Show(string str)
        {
            Console.WriteLine(str);
        }

        private void Show2(string str)
        {
            Console.WriteLine(str);
        }

        public void Show3<T>(T t)
        {
            Console.WriteLine(t.ToString());
        }
    }
}