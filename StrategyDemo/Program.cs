/***********************************************************************************************************************************
 * 
 * 功能：设计模式——策略模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-2-15
 * 
 * 参考：
 * Demo与2014-10-6补充；
 * 
 * 备注：
 * http://www.cnblogs.com/justinw/archive/2007/02/06/641414.html    (Header First Design Patterns)
 * 继承，并不是所有的鸭子都会叫、会飞，如橡皮鸭不会飞，且鸭子的飞行、叫的方式不同；
 * 接口，接口不具有实现代码，继承接口无法达到代码复用目的，所有的接口实现者都需要重复实现接口功能；
 * 
 * 把会变化的部分提取、封装，让其他部分不受影响，
 * 最终，用接口分离来分离问题中变化的部分；
 * 
 * 针对接口编程，即针对超类型(supertype)编程(区别针对实现编程)；
 * 变量的声明类型应该是超类型，通常是一个抽象类或者是一个接口，如此，只要是具体实现此超类型的类所产生的对象，都可以指定给这个变量。
 * 这也意味着，声明类时不用理会以后执行时的真正对象类型！
 * 
 * http://blog.csdn.net/hguisu/article/details/7558249 (PHP)
 * http://www.cnblogs.com/BoyXiao/archive/2010/05/02/1725972.html (上学的例子，易理解)
 * 
 ***********************************************************************************************************************************/

using StrategyDemo.Advanced.Implements;

namespace StrategyDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using StrategyDemo.Advanced.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            AdvancedTest();

            Console.ReadKey(true);
        }

        static void AdvancedTest()
        {
            RubberDuck rubber = new RubberDuck();
            rubber.PerformFly();
            rubber.PerformQuack();

            rubber.SetFlyBehavior(new FlyWithWings());
            rubber.SetQuackBehavior(new QuackCommon());
            rubber.PerformFly();
            rubber.PerformQuack();
        }
    }
}
