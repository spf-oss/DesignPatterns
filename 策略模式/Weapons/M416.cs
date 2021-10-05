using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    public class M416 : IWeapons
    {
        private readonly int weili = 80;

        public void UseWeapons()
        {
            Console.WriteLine("使用M416造成伤害：{0}", weili);
        }
    }
}
