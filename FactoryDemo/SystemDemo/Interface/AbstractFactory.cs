﻿// -----------------------------------------------------------------------
// <copyright file="AbstractFactory.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FactoryDemo.SystemDemo.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Button CreateButton();

        public abstract TextBox CreateTextBox();
    }
}
