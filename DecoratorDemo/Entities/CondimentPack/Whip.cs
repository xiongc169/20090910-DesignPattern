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
    /// 奶泡
    /// </summary>
    public class Whip : Condiment
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDesc()
        {
            return beverage.GetDesc() + ",Whip";
        }

        /// <summary>
        /// 计算带Whip饮料的价钱！
        /// </summary>
        /// <returns></returns>
        public override double GetCost()
        {
            return 2.74 + beverage.GetCost();
        }
    }
}
