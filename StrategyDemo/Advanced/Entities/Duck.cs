// -----------------------------------------------------------------------
// <copyright file="Duck.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------


namespace StrategyDemo.Advanced.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using StrategyDemo.Advanced.Interfaces;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior;

        public IQuackBehavior QuackBehavior;

        public void PerformFly()
        {
            //委托给行为类
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            //委托给行为类
            QuackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }
    }
}
