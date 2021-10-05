using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class Subject : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        private float temp = 11;

        private float humidity = 27;

        private float pressure = 27;

        public void NotifyObserver()
        {
            foreach (var item in observers)
            {
                item.Update(temp, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
