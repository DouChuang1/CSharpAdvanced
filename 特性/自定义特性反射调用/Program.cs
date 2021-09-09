using System;

namespace ConsoleApplication16
{
    //特性创建调用 使用反射调用
    public class NiuAttribute : Attribute
    {
        private string showInfo;
        public NiuAttribute(string str)
        {
            showInfo = str;
        }

        public string ShowInfo
        {
            get => showInfo;
            set => showInfo = value;
        }
    }
    [Niu("牛神特性")]
    public class UseAttribute
    {
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Type type = typeof(UseAttribute);
            object[] customAttributs = type.GetCustomAttributes(true);
            foreach (var customAttribute in customAttributs)
            {
                NiuAttribute niuAttribute = customAttribute as NiuAttribute;
                if (niuAttribute != null)
                {
                    Console.WriteLine(niuAttribute.ShowInfo);
                }
            }
        }
    }
}