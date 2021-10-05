using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    /// <summary>
    /// 低咖啡因咖啡
    /// </summary>
    internal class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "低咖啡因咖啡";
        }

        public override int Cost()
        {
            return 4;
        }
    }
}
