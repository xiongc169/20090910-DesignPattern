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

namespace AdapterDemo.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 火鸡接口
    /// </summary>
    public interface ITurkey
    {
        /// <summary>
        /// 咯咯叫
        /// </summary>
        void Gobble();

        /// <summary>
        /// 飞(飞的不远)
        /// </summary>
        void Fly();
    }
}
