﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    internal class PzDisplay : IDisplay
    {
        private ISubject subject;

        private float temp;

        private float humidity;

        private float pressure;

        public PzDisplay(ISubject subject)
        {
            this.subject = subject;

            this.subject.RegisterObserver(this);
        }

        public void DisplayElement()
        {
            Console.WriteLine("彭锱的显示面板，温度：{0}，湿度：{1}，气压：{2}", temp, humidity, pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;

            this.humidity = humidity;

            this.pressure = pressure;

            DisplayElement();
        }
    }
}
