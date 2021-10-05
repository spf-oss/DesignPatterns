using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    internal class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override int Cost()
        {
            return 1 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",奶泡";
        }
    }
}
