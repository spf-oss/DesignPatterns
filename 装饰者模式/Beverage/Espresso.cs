using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    class Espresso : Beverage
    {
        /// <summary>
        /// 浓缩咖啡
        /// </summary>
        /// <param name="description"></param>
        public Espresso()
        {
            this.description = "浓缩咖啡";
        }

        /// <summary>
        /// 返回浓缩咖啡的成本
        /// </summary>
        /// <returns></returns>
        public override int Cost()
        {
            return 5;
        }
    }
}
