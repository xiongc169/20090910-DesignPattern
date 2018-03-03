/***********************************************************************************************************************************
 * 
 * 功能：设计模式——单例模式
 * 
 * 作者：
 * 
 * 时间：
 * 
 * 参考：
 * 学习static关键字；
 * Singleton与ThreadPool类相似，注意其中volatile关键字的用法；
 * 
 * 备注：
 * http://www.cnblogs.com/BoyXiao/archive/2010/05/07/1729376.html?login=1
 * 单例模式（单件模式）的作用就是保证在整个应用程序的生命周期中，任何一个时刻，单例类的实例都只存在一个（当然也可以不存在）。如电脑连接打印机程序、线程池等；
 * 
 ***********************************************************************************************************************************/

namespace SingletonDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            SingletonTest();
            Console.ReadKey(true);
        }

        /// <summary>
        /// 单例模式
        /// </summary>
        static void SingleInstanceTest()
        {
            if (!ProgramHelper.SingleRunWinApp())
            {
                Console.WriteLine("程序启动失败：只能运行一个实例！！！");
            }
            else
            {
                Console.WriteLine("程序启动成功！！！");
            }
        }

        static void SingletonTest()
        {
            Singleton singletonA = Singleton.GetInstance();
            Singleton singletonB = Singleton.GetInstance();

            if (singletonA.Equals(singletonB))
            {
                Console.WriteLine("singletonA 和 singletonB 代表的是同一个实例");
            }
            else
            {
                Console.WriteLine("singletonA 和 singletonB 代表的是不同一个实例");
            }
        }
    }
}
