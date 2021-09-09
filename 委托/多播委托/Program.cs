using System;

namespace ConsoleApplication19
{
    internal class Program
    {
        //多播委托

        delegate void MulticastTest();
        public class MulticastDelegateTest
        {
            public void Show()
            {
                MulticastTest multicastTest = new MulticastTest(MethodTest);

                multicastTest += MethodTest1;
                
                multicastTest += delegate { Console.WriteLine("Niu"); };
                
                multicastTest?.Invoke();

                multicastTest -= MethodTest1;
                multicastTest?.Invoke();
            }

            public void MethodTest()
            {
                Console.WriteLine("Method Test");
            }
            
            public void MethodTest1()
            {
                Console.WriteLine("Method Test1");
            }
        }
        public static void Main(string[] args)
        {
            MulticastDelegateTest multicastDelegateTest = new MulticastDelegateTest();
            multicastDelegateTest.Show();
        }
    }
}