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

using System;

namespace StrategyDemo.Advanced.Implements
{
    using StrategyDemo.Advanced.Interfaces;

    /// <summary>
    /// 实现了所有不会飞鸭子的动作
    /// </summary>
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I Cannot Fly!");
        }
    }
}
