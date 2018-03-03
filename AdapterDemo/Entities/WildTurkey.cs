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

namespace AdapterDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AdapterDemo.Interfaces;

    /// <summary>
    /// 火鸡实体
    /// </summary>
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("gobble,gobble......");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance......");
        }
    }
}
