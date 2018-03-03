/***********************************************************************************************************************************
 * 
 * 功能：设计模式——模板方法模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-24
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace TemplateMethodDemo.Entities
{
    using System;

    /// <summary>
    /// 咖啡
    /// </summary>
    public class Coffee
    {
        /// <summary>
        /// 冲泡咖啡
        /// </summary>
        public void PrepareCoffee()
        {
            BoilWater();
            BrewCoffeeGrind();
            PourInCup();
            AddSugarAndMilk();
        }

        /// <summary>
        /// 烧水
        /// </summary>
        private void BoilWater()
        {
            Console.WriteLine("Boiling Water......");
        }

        /// <summary>
        /// 冲泡咖啡
        /// </summary>
        private void BrewCoffeeGrind()
        {
            Console.WriteLine("Dripping Coffee through filter......");
        }

        /// <summary>
        /// 倒进杯子
        /// </summary>
        private void PourInCup()
        {
            Console.WriteLine("Pouring into Cup......");
        }

        /// <summary>
        /// 加糖、牛奶
        /// </summary>
        private void AddSugarAndMilk()
        {
            Console.WriteLine("Adding Sugar And Milk......");
        }
    }
}
