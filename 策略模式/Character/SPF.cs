using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    class SPF : ICharacter
    {
        private IWeapons weapons;

        public SPF(IWeapons w)
        {
            weapons = w;
        }

        public void Attack()
        {
            weapons.UseWeapons();
        }

        public void SetWeapons(IWeapons w)
        {
            weapons = w;
        }
    }
}
