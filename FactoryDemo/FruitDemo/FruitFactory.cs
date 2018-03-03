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
    /// 水果工厂
    /// </summary>
    public class FruitFactory
    {
        public FruitFactory()
        { }

        /// <summary>
        /// 简单工厂：用来封装实例化活动；
        /// 实现了针对接口编程，但违背了开闭原则(扩展比较困难)；
        /// </summary>
        /// <param name="fruitType"></param>
        /// <returns></returns>
        public static Fruit CreateFruit(string fruitType)
        {
            if (!string.IsNullOrEmpty(fruitType))
            {
                switch (fruitType)
                {
                    case "Apple":
                        return new Apple();
                    case "Orange":
                        return new Orange();
                    case "Pear":
                        return new Pear();
                    default:
                        return null;
                }
            }
            return null;
        }
    }
}
