using  System;
namespace IComparableInterface
{
    //类实现IComparable 让sort方法可以用于MyClass类型的对象
    //1.基类列表列出接口名称 2.为接口每一个成员提供实现 3.实现CompareTo方法遵循接口文档的定义
    class MyClass : IComparable
    {
        public int classValue;

        public int CompareTo(object obj)
        {
            MyClass mc = (MyClass) obj;
            if (this.classValue < mc.classValue) return -1;
            if (this.classValue > mc.classValue) return 1;
            return 0;
        }
    }
    internal class Program
    {
        static void Print(string s, MyClass[] mcArray)
        {
            Console.WriteLine(s);
            foreach (var m in mcArray)
            {
                Console.Write($"{m.classValue}");
            }
            Console.WriteLine("");
        }
        
        public static void Main(string[] args)
        {
            var myInt = new[] {5, 3, 8, 1, 9, 2};

            MyClass[] mcArr = new MyClass[6];

            for (int i = 0; i < 6; i++)
            {
                mcArr[i] = new MyClass();
                mcArr[i].classValue = myInt[i];
            }
            
            Print("Init order",mcArr);
            Array.Sort(mcArr);
            Print("sorted order",mcArr);
        }
    }
}