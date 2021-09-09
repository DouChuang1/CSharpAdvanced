using System;

namespace ConsoleApplication21
{
    //1.声明一个委托 2.创建一个类 声明事件以及执行事件 3.绑定其它类真正事件执行逻辑 
    //自定义标准的事件
    
    
    //发布者  事件的定义和调用 触发事件也可以在这里
    class Publisher
    {
        public event EventHandler<CustomEventArgs> CustomEvent; // EventHandler 标准的委托

        public void DoSomething()
        {
            OnCustomEvent(new CustomEventArgs("我是事件参数"));
        }

        protected virtual void OnCustomEvent(CustomEventArgs e)
        {
            CustomEvent?.Invoke(this,e);
        }
    }

    //事件订阅者 事件方法编写和订阅功能
    class Subsciber
    {
        private readonly string Str;
        public Subsciber(string str, Publisher publisher)
        {
            Str = str;
            publisher.CustomEvent += HandleCustomEvent;
        }
        
        private void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"发布者：{sender.GetType()},订阅者：{Str},参数是：{e.Message}");
        }
    }

    class CustomEventArgs:EventArgs
    {
        public CustomEventArgs(string str)
        {
            Message = str;
        }

        public string Message
        {
            get;
            set;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subsciber subsciber = new Subsciber("Subscribe",publisher);
            
            publisher.DoSomething();
        }
    }
}