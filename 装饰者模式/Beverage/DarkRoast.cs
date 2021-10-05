using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    /// <summary>
    /// 深培咖啡（一种饮料的具体实现）
    /// </summary>
    internal class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "深培咖啡";
        }

        /// <summary>
        /// 实现cost方法，返回深培咖啡的价格
        /// </summary>
        /// <returns></returns>
        public override int Cost()
        {
            return 3;
        }
    }
}
