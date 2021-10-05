using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    public class knife : IWeapons
    {
        private readonly int weili = 10;

        public void UseWeapons()
        {
            Console.WriteLine("使用小刀造成伤害：{0}点", weili);
        }
    }
}
