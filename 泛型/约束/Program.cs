using System;

namespace ConsoleApplication7
{

    interface IStudent<T>
    {
        
    }

    interface IStudent
    {
        //没有构造函数
    }

    class Student
    {
        //默认一个无参构造 
    }
    
    
    internal class Program
    {   
        //约束  可以多个  但是不能相互矛盾
        //new()  表示T类型只接收带一个无参数的构造函数 
        //struct 值类型约束  结构体 数值类型int 枚举 bool
        //class 引用类型约束  数组 类 接口 委托 object string
        //自定义类型约束  基类型约束 接口类型约束
        public static void Show<T,K>(T t,K k) 
            where T : Student //自定义类型
            where K : new()
        {
            Console.WriteLine(nameof(t));
        }
        
        public static void Main(string[] args)
        {
            Student student = new Student();
            Show(student,student);
        }
    }
}