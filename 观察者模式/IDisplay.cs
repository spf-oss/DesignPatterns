using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 显示面板
    /// </summary>
    public interface IDisplay : IObserver
    {
        /// <summary>
        /// 显示气温、湿度、气压
        /// </summary>
        public void DisplayElement();
    }
}
