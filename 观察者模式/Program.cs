using System;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建主题
            ISubject subject = new Subject();

            IDisplay spf = new SpfDisplay(subject);

            IDisplay yq = new YqDisplay(subject);

            IDisplay tqx = new TqxDisplay(subject);

            IDisplay pz = new PzDisplay(subject);

            subject.NotifyObserver();

            Console.ReadKey();
        }
    }
}
