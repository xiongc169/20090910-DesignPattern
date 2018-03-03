/***********************************************************************************************************************************
 * 
 * 功能：设计模式——代理模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-30(It's a happy day,isn't is?)
 * 
 * 参考：
 * 
 * 备注：
 * 第十一章、代理模式
 * 远程代理，好比远程对象的本地代表；
 * 远程对象，一种对象，活在不同Java虚拟机(JVM)堆中(或在不同的地址空间运行的远程对象)；
 * 本地代表，可以由本地方法调用的对象，其行为会转发到远程对象中；
 * 
 * Java内置了远程调用的功能，要求代码符合RMI要求即可；RMI可以让我们找到远程JVM内的对象，并允许我们调用它的方法；
 * 
 * 如何利用RMI进行远程方法调用？？
 * 示意图：客户对象 <----> 客户辅助对象[即stub，桩] <----> 服务辅助对象[即skeleton，骨架] <----> 服务对象；
 * RMI提供了客户辅助对象、服务辅助对象，为客户辅助对象创建和服务辅助对象相同的方法；
 * 
 * 制作远程服务概要(将一个普通对象变成可以被远程客户调用的远程对象)
 * 1、制作远程接口(stub和实际的服务都实现此接口)；
 * 2、制作远程的实现；
 * 3、利用rmic产生的stub和skeleton，即客户、服务的辅助类(JDK中可找到rmic工具)；
 * 4、启动RMI registry(rmiregistry像是电话簿，客户可以从中查到代理的位置)；
 * 5、开始远程服务(让服务对象开始运行)；
 * 
 * 潘金莲-王婆-西门庆Demo
 * http://yangguangfu.iteye.com/blog/815787
 * 
 ***********************************************************************************************************************************/

namespace ProxyDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using StatePattern.Upgrade;
    using Entities;

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
                return;

            string location = args[0];
            string countStr = args[1];
            int count = 0;
            Int32.TryParse(countStr, out count);

            GumballMachineUpgrade gumballMachine = new GumballMachineUpgrade(location, count);
            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);
            gumballMonitor.Report();

            Console.ReadKey(true);
        }

        static void MonitorTest()
        {

        }
    }
}
