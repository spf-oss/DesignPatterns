using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 观察者（被通知的对象）
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 更新方法
        /// </summary>
        /// <param name="temp">温度</param>
        /// <param name="humidity">湿度</param>
        /// <param name="pressure">气压</param>
        public void Update(float temp,float humidity,float pressure);
    }
}
