using System;

namespace ConsoleApplication20
{
    //委托事件
    //事件 是委托的安全版本 类的外部不能用=来操作 只能+= 
    //2.事件类的外部 不能调用事件 另外事件就是在委托前面增加一个event 关键字

    delegate void NiuDelegate();

    /// <summary>
    /// 定义事件调用事件在一个类里面
    /// </summary>
    class TestEvent
    {
        public event NiuDelegate NiuEvent;

        public void Invoke()
        {
            NiuEvent?.Invoke();
        }
    }
     
    internal class Program
    {
        public static void Main(string[] args)
        {
            TestEvent testEvent = new TestEvent();
            testEvent.NiuEvent += delegate
            {
                Console.WriteLine("事件");
            };
            
            testEvent.Invoke();
        }
    }
}