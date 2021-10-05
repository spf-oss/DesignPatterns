using System;

namespace 装饰者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //浓缩咖啡什么都不加
            Beverage beverage = new Espresso();

            Console.WriteLine("咖啡描述：{0}，咖啡价格：{1}", beverage.GetDescription(), beverage.Cost());

            //深培咖啡加奶泡
            Beverage beverage1 = new DarkRoast();

            beverage1 = new Whip(beverage1);

            Console.WriteLine("咖啡描述：{0}，咖啡价格：{1}", beverage1.GetDescription(), beverage1.Cost());

            //低咖啡因咖啡加豆奶和摩卡
            Beverage beverage2 = new Decaf();

            beverage2 = new Soy(beverage2);

            beverage2 = new Mocha(beverage2);

            Console.WriteLine("咖啡描述：{0}，咖啡价格：{1}", beverage2.GetDescription(), beverage2.Cost());

            Console.ReadKey();
        }
    }
}
