// -----------------------------------------------------------------------
// <copyright file="WindowsFactory.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using FactoryDemo.SystemDemo.Interface;

namespace FactoryDemo.SystemDemo.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class WindowsFactory : AbstractFactory
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }

        public override TextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
