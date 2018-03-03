/***********************************************************************************************************************************
 * 
 * 功能：设计模式——原型模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-16
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace PrototypeDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using PrototypeDemo.Implements;

    class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.ReadKey(true);
        }

        static void Test()
        {
            ConcretePrototype prototype = new ConcretePrototype();
            for (int i = 0; i < 10; i++)
            {
                ConcretePrototype type = (ConcretePrototype)prototype.Clone();
                type.Display();
            }
        }
    }
}
