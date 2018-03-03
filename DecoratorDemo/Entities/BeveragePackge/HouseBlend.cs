﻿/***********************************************************************************************************************************
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


namespace DecoratorDemo.Entities.BeveragePackge
{
    using DecoratorDemo.Abstract;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            desc = "HouseBlend";
        }

        public override double GetCost()
        {
            return 0.98;
        }
    }
}
