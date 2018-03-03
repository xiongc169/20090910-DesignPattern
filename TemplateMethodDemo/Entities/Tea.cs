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
    /// 茶
    /// </summary>
    public class Tea
    {
        /// <summary>
        /// 泡茶
        /// </summary>
        public void PrepareTea()
        {
            BoilWater();
            SteepTeaBag();
            PourIntoCup();
            AddLemon();
        }

        /// <summary>
        /// 烧水
        /// </summary>
        private void BoilWater()
        {
            Console.WriteLine("Boiling Water......");
        }

        /// <summary>
        /// 沏茶
        /// </summary>
        private void SteepTeaBag()
        {
            Console.WriteLine("Steeping the Tea......");
        }

        /// <summary>
        /// 倒进杯子
        /// </summary>
        private void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup......");
        }

        /// <summary>
        /// 加柠檬
        /// </summary>
        private void AddLemon()
        {
            Console.WriteLine("Adding Lemon......");
        }
    }
}
