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
    /// 不会叫
    /// </summary>
    class QuackNoWay : IQuackBehavior
    {
        public void Quack()
        {
           Console.WriteLine("I Cannot Quack!");
        }
    }
}
