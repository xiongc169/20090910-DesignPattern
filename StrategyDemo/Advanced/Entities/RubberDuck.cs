// -----------------------------------------------------------------------
// <copyright file="RubberDuck.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------


namespace StrategyDemo.Advanced.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using StrategyDemo.Advanced.Implements;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new QuackSqueak();
        }
    }
}
