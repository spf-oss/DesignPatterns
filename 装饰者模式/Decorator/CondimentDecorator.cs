using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰者模式
{
    internal abstract class CondimentDecorator : Beverage
    {
        /// <summary>
        /// 所有的调料装饰者必须重新实现GetDescription()方法
        /// 这样才能够用递归的方式来得到所选饮料的整体描述
        /// </summary>
        /// <returns></returns>
        public override abstract string GetDescription();

    }
}
