/***********************************************************************************************************************************
 * 
 * 功能：设计模式——适配器模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-23
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace AdapterDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AdapterDemo.Entities;
    using AdapterDemo.Interfaces;
    using AdapterDemo.Adapter;

    class Program
    {
        static void Main(string[] args)
        {
            TestAdapter();
            Console.ReadKey(true);
        }

        /// <summary>
        /// 测试适配器
        /// </summary>
        static void TestAdapter()
        {
            MallarDuck duck = new MallarDuck();
            WildTurkey turkey = new WildTurkey();

            IDuck toDuck = new TurkeyAdapter(turkey);

            duck.Quack();
            duck.Fly();

            turkey.Gobble();
            turkey.Fly();

            toDuck.Quack();
            toDuck.Fly();
        }
    }
}
