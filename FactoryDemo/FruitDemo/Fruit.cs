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
    /// 抽象水果类
    /// </summary>
    public abstract class Fruit
    {
        public abstract void Display();
    }
}
