/***********************************************************************************************************************************
 * 
 * 功能：装饰者
 * 
 * 作者：
 * 
 * 时间：
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace DecoratorDemo.Entities.CondimentPack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using DecoratorDemo.Abstract;

    /// <summary>
    /// 摩卡
    /// </summary>
    public class Mocha : Condiment
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDesc()
        {
            return beverage.GetDesc() + ",Mocha";
        }

        /// <summary>
        /// 计算带Mocha饮料的价钱！
        /// 首先调用委托给被装饰对象，以计算价钱，然后再加上Mocha的价钱，得到最后结果。
        /// </summary>
        /// <returns></returns>
        public override double GetCost()
        {
            return 10.2 + beverage.GetCost();
        }
    }
}
