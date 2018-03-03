/***********************************************************************************************************************************
 * 
 * 功能：设计模式——迭代器模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-25
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace IteratorDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using IteratorDemo.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            WaiterTest();
            Console.ReadKey(true);
        }

        static void WaiterTest()
        {
            Waiter waiter=new Waiter();
            waiter.Print();
        }
    }
}
