/***********************************************************************************************************************************
 * 
 * 功能：设计模式——装饰者模式
 * 
 * 作者：
 * 
 * 时间：
 * 
 * 参考：
 * 
 * 备注：以饮料为主体，在运行时调用调料装饰饮料；
 * 
 * http://www.cnblogs.com/BoyXiao/archive/2010/05/04/1727383.html
 * 装饰者模式动态的给一个对象添加一些责任（也就是功能）；
 * 若要扩展功能的话，装饰者提供了比继承更有弹性的替代方案，因为装饰者模式比生成子类更加灵活。
 * 
 ***********************************************************************************************************************************/

namespace DecoratorDemo
{
    using System;
    using Abstract;
    using Entities.BeveragePackge;
    using Entities.CondimentPack;

    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso = new Whip(espresso);
            Console.WriteLine("Espresso desc {0},Cost {1}", espresso.GetDesc(), espresso.GetCost());

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine("DarkRoast desc {0},Cost {1}", darkRoast.GetDesc(), darkRoast.GetCost());

            Console.ReadKey(true);
        }
    }
}
