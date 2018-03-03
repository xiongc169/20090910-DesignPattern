/***********************************************************************************************************************************
 * 
 * 功能：设计模式——策略模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-2-15
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace StrategyDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 鸭子的父类
    /// </summary>
    class Duck
    {
        public void Quack()
        { }

        public void Swim()
        { }

        public void Display()
        { }

        public void Fly()
        { }
    }
}
