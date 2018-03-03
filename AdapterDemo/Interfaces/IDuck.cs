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
    /// 鸭子接口
    /// </summary>
    public interface IDuck
    {
        /// <summary>
        /// 呱呱叫
        /// </summary>
        void Quack();

        /// <summary>
        /// 飞
        /// </summary>
        void Fly();
    }
}
