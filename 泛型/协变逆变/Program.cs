using  System.Collections.Generic;

;
namespace ConsoleApplication8
{
    //泛型用处
    //让泛型类 方法 接口 委托 更通用
    //约束 
    //协变 逆变
    class People
    {
        
    }

    class Teacher:People
    {
        
    }

    interface IListOut<out T>
    {
        T GetT();
    }

    class ListOut<T> : IListOut<T>
    {
        public T GetT()
        {
            return default(T); //值类型返回0 引用类型返回null
        }
    }
    
    interface IListIn<in T>
    {
        void Show(T t);
    }

    class ListIn<T> : IListIn<T>
    {
        public void  Show(T t)
        {
           
        }
    }

    interface IOutInList<in inT,out outT>
    {
        void Show(inT t);
        outT Get();
        outT Do(inT t);
    }

    public class OutInList<T1, T2> : IOutInList<T1, T2>
    {
        public void Show(T1 t)
        {
            
        }

        public T2 Get()
        {
            return default(T2);
        }

        public T2 Do(T1 t)
        {
            return default(T2);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            People people = new People();
            People people1 = new Teacher();
            Teacher teacher = new Teacher();

            List<People> peoples = new List<People>();
            
            //List<People> peoples1 = new List<Teacher>()  错误 类型不同 语法规则不支持
            
            //上面语法规则不支持 之后net3.0有协变 逆变
            //协变  逆变 针对泛型接口和泛型委托来说的 离开了就没这个说法
            //out 关键字代表协变 in代表逆变
            //  协变只能返回结果 不能做参数
            // 逆变 只能做参数  不能做返回值
            
            //在知道自己或者别人以后有用到父类通过子类实例化 或者子类通过父类实例化 可以用out 或者in 关键字
            IListOut<People> listOut = new ListOut<People>();
            IListOut<People> listOut1 = new ListOut<Teacher>(); //协变

            IListIn<Teacher> listIn = new ListIn<Teacher>();
            IListIn<Teacher> listIn1 = new ListIn<People>(); //逆变

            IOutInList<Teacher, People> myList1 = new OutInList<Teacher, People>();
            IOutInList<Teacher, People> myList2 = new OutInList<Teacher, Teacher>(); //协变

            IOutInList<Teacher, People> myList3 = new OutInList<People, People>(); //逆变
            IOutInList<Teacher, People> myList4 = new OutInList<People, Teacher>(); //逆变 协变
        }
    }
}