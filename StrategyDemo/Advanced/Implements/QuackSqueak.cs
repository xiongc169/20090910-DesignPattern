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

namespace StrategyDemo.Advanced.Implements
{
    using System;
    using StrategyDemo.Advanced.Interfaces;

    /// <summary>
    /// 橡皮鸭的“吱吱”
    /// </summary>
    class QuackSqueak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak,Squeak!");
        }
    }
}
