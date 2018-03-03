// -----------------------------------------------------------------------
// <copyright file="Bus.cs" company="Microsoft">
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
    public class Bus : ICar
    {
        public override void SetType()
        {
            this.Type = "公共汽车";
        }
    }
}
