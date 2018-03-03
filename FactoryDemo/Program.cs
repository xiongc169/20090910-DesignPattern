/***********************************************************************************************************************************
 * 
 * 功能：设计模式——工厂模式
 * 
 * 作者：
 * 
 * 时间：
 * 
 * 参考：
 * 
 * 备注：
 * http://www.cnblogs.com/BoyXiao/archive/2010/05/06/1728808.html
 * 有时实例化操作不应公开的进行，应该更好的使用new关键字；
 * 用工厂方法能降低客户端和需要实例化对象之间的耦合
 * 
 * 简单工厂、工厂方法、抽象工厂；
 * 
 ***********************************************************************************************************************************/

namespace FactoryDemo
{
    using System;
    using FruitDemo;
    using FruitDemo.Advanceed;
    using SystemDemo.Implement;
    using SystemDemo.Interface;

    class Program
    {
        static void Main(string[] args)
        {
            SystemDemo();

            Console.ReadKey(true);
        }

        /// <summary>
        /// 简单工厂：
        /// 简单工厂把全部事情放在一个地方(类)完成；
        /// </summary>
        static void FruitFactoryTest()
        {
            //创建一个苹果实例 
            //并且调用这个实例的 Display 方法 
            FruitFactory.CreateFruit("Apple").Display();

            //创建一个橘子实例 
            //并且调用这个实例的 Display 方法 
            FruitFactory.CreateFruit("Orange").Display();

            //创建一个梨子实例 
            //并且调用这个实例的 Display 方法 
            FruitFactory.CreateFruit("Pear").Display();

            Console.ReadLine();
        }

        /// <summary>
        /// 工厂方法：
        /// 创建一个框架(抽象类)，然后让子类决定如何实现；
        /// </summary>
        static void AdvancedFactory()
        {
            FruitFactoryB factoryB = new AppleFactory();
            factoryB.GetFruit().Display();

            factoryB = new OrangeFactory();
            factoryB.GetFruit().Display();

            factoryB = new PearFactory();
            factoryB.GetFruit().Display();
        }

        /// <summary>
        /// 抽象工厂：
        /// 注意产品族的概念，Button产品族、TextBox产品族；
        /// 若产品族过多，整个结构会过于复杂臃肿；
        /// </summary>
        static void SystemDemo()
        {
            AbstractFactory factory = new LinuxFactory();
            factory.CreateButton().DisplayButton();
            factory.CreateTextBox().DisplayTextBox();

            //如果系统本来是基于 Linux 的话，只需更改一行代码factory = new WindowsFactory(); 即可实现将系统更改为 Windows
            factory = new WindowsFactory();
            factory.CreateButton().DisplayButton();
            factory.CreateTextBox().DisplayTextBox();
        }
    }
}
