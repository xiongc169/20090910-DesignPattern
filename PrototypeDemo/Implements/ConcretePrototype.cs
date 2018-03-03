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

namespace PrototypeDemo.Implements
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ConcretePrototype : Prototype
    {
        public void Display()
        {
            Console.WriteLine("原型模式实现类");
        }
    }
}
