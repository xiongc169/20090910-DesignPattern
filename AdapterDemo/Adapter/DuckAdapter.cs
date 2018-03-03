/***********************************************************************************************************************************
 * 
 * 功能：设计模式——适配器模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-23
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace AdapterDemo.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AdapterDemo.Interfaces;

    /// <summary>
    /// 鸭子适配器
    /// </summary>
    public class DuckAdapter : ITurkey
    {
        private IDuck iDuck;

        public DuckAdapter(IDuck Iduck)
        {
            this.iDuck = Iduck;
        }

        public void Gobble()
        {
            this.iDuck.Quack();
        }

        public void Fly()
        {
            this.iDuck.Fly();
        }
    }
}
