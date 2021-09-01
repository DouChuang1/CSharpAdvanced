using System;

namespace ConsoleApplication5
{
    interface IDataRetrieve
    {
        int GetData();
    }

    interface IDataStore
    {
        void SetData(int x);
    }

    interface IDataIO : IDataRetrieve,IDataStore
    {
        
    }

    class MyData : IDataIO
    {
        private int nData;

        public int GetData()
        {
            return nData;
        }

        public void SetData(int x)
        {
            nData = x;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyData md = new MyData();
            md.SetData(5);
            
            Console.WriteLine(md.GetData());
        }
    }
}