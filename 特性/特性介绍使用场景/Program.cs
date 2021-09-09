using System;
using System.Diagnostics;

namespace ConsoleApplication15
{
    //特性使用场景 数据验证
    
    //特性分类
    //1.系统自带  有一些影响编译器运行
    //2.自定义
    internal class Program
    {
        class NiuGod
        {
            public NiuGod()
            {
                
            }
            [DebuggerStepThrough]
            public void Learn()
            {
                Console.WriteLine("Niu Learn");
            }
        }
        public static void Main(string[] args)
        {
            NiuGod niuGod = new NiuGod();
            niuGod.Learn();
        }
    }
}