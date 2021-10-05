using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    /// <summary>
    /// 豆浆调料类
    /// </summary>
    internal class Soy : CondimentDecorator
    {
        protected Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override int Cost()
        {
            return 1 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",豆浆调料类";
        }
    }
}
