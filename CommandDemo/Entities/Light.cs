/***********************************************************************************************************************************
 * 
 * 功能：设计模式——命令模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-22
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace CommandDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 电灯类
    /// </summary>
    public class Light
    {
        /// <summary>
        /// 如客厅的灯、厨房的灯
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Status { get; set; }
    }
}
