using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    class AK : IWeapons
    {
        private readonly int weili = 100;

        public void UseWeapons()
        {
            Console.WriteLine("使用KA造成伤害：{0}点",weili);
        }
    }
}
