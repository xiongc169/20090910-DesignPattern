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
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 咖啡因饮料
    /// </summary>
    public abstract class CoffeeineBervage
    {
        /// <summary>
        /// 准备饮料(不希望子类覆盖这个方法，该用什么关键字，类似Java中的final关键字)；
        /// 传说中的模板方法:模板方法定义了一个算法的步骤，并允许子类为一个或多个步骤提供实现；
        /// </summary>
        public void PrepareBervage()
        {
            BoilWater();
            Brew();
            PourIntoCup();
            AddCondinents();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water......");
        }

        private void PourIntoCup()
        {
            Console.WriteLine("Pouring into Cup......");
        }

        /// <summary>
        /// 泛华这两个方法；
        /// 咖啡、茶的这两个方法的做法不同，所以这两个方法声明为抽象，具体实现由子类完成；
        /// </summary>
        public abstract void Brew();

        public abstract void AddCondinents();
    }
}
