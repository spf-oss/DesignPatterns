using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    /// <summary>
    /// 摩卡调料
    /// </summary>
    internal class Mocha : CondimentDecorator
    {
        /// <summary>
        /// 用一个变量记录饮料，也就是被装饰者
        /// </summary>
        protected Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }


        public override int Cost()
        {
            return 1 + beverage.Cost();
        }

        /// <summary>
        /// 在原料的基础上添加对Mocha的描述（原来的饮料加入了Mocha调料，被Mocha装饰）
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return beverage.GetDescription() + ",摩卡";
        }
    }
}
