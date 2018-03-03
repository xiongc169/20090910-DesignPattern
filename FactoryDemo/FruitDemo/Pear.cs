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
 * 
 ***********************************************************************************************************************************/

namespace FactoryDemo.FruitDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 梨子
    /// </summary>
    public class Pear : Fruit
    {
        public override void Display()
        {
            Console.WriteLine("我的名字是：梨子 ，主要特性为滋肝润胃"); 
        }
    }
}
