using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    /// <summary>
    /// 饮料抽象类
    /// </summary>
    internal abstract class Beverage
    {
        protected string description;

        public virtual string GetDescription()
        {
            return description;
        }

        /// <summary>
        /// 计算成本
        /// </summary>
        /// <returns></returns>
        public abstract int Cost();
    }
}
