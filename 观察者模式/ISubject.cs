using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    /// <summary>
    /// 主题（通知对象）
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 注册观察者（被通知的对象）
        /// </summary>
        public void RegisterObserver(IObserver observer);

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer);

        /// <summary>
        /// 通知观察者
        /// </summary>
        /// <param name="observer"></param>
        public void NotifyObserver();
    }
}
