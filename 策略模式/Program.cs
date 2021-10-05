using System;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            var weapons = new M416();

            var spf = new SPF(weapons);

            spf.Attack();

            spf.SetWeapons(new AK());

            spf.Attack();

            Console.WriteLine();
        }
    }
}
