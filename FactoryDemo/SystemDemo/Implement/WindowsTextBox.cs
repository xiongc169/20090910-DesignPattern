// -----------------------------------------------------------------------
// <copyright file="WindowsTextBox.cs" company="Microsoft">
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
    public class WindowsTextBox : TextBox
    {
        public override void DisplayTextBox()
        {
            Console.WriteLine("我的类型是 {0}", this.GetType().ToString());
        }
    }
}
