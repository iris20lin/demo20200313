using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入扣血量");
            int hp = 100;
            Console.WriteLine(hp);
            while (true)
            {
                //判斷死亡
                if (hp <= 0)
                {
                    Console.WriteLine("你已經死了...");
                    break;
                }

                //檢查是否有人攻擊
                string attackString = Console.ReadLine();
                int attack = int.Parse(attackString);

                //扣血
                hp = hp - attack;
            }
            Console.ReadLine();
        }
    }
}
