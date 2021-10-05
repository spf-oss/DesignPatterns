using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    /// <summary>
    /// 角色接口
    /// </summary>
    interface ICharacter
    {
        public void SetWeapons(IWeapons w);

        public void Attack();
    }
}
