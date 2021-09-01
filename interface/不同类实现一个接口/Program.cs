using System;

namespace ConsoleApplication1
{
    interface IPrintInfo
    {
        int GetHp();
        int GetMp();
    }
    class Player:IPrintInfo
    {
        public  int hp;
        public  int mp;

        public int GetHp()
        {
            return hp;
        }
            
        public int GetMp()
        {
            return mp;
        }
    }

    class Monster:IPrintInfo
    {
        public int hp;
        public int mp;
        public int attack;
            
        public int GetHp()
        {
            return hp;
        }
            
        public int GetMp()
        {
            return mp;
        }
    }
    
    class Program
    {
        //使用接口 不管传入是player还是monster 都可以正确打印
        static void PrintInfo(IPrintInfo iprint)
        {
            Console.WriteLine("Hp: {0},Mp: {1}",iprint.GetHp(),iprint.GetMp());
        }
        
        public static void Main(string[] args)
        {
            Player player = new Player() {hp = 100, mp = 100};

            Monster monster = new Monster() {hp = 300, mp = 300, attack = 50};
            
            PrintInfo(player);
            PrintInfo(monster);
            Console.Read();
        }
    }
}