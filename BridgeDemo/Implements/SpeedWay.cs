// -----------------------------------------------------------------------
// <copyright file="SpeedWay.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using BridgeDemo.Interfaces;

namespace BridgeDemo.Implements
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SpeedWay : IRoad
    {
        public override void Desc()
        {
            Console.WriteLine("{0} 行驶在 SpeedWay 上...", this.Car.Type);
        }
    }
}
