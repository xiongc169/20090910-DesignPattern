/***********************************************************************************************************************************
 * 
 * 功能：设计模式——责任链模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-12
 * 
 * 参考：
 * 
 * 备注：http://www.cnblogs.com/kym/archive/2009/04/06/1430078.html
 * 请假的例子
 * 
 ***********************************************************************************************************************************/

namespace ResponsibilityChainDemo.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ResponsibilityChainDemo.Implements;

    /// <summary>
    /// 抽象处理者接口
    /// </summary>
    public abstract class IBoss
    {
        /// <summary>
        /// 继任者
        /// </summary>
        public IBoss Successor;

        public abstract HolidayRequest CheckHoliday(HolidayRequest requests);
    }
}
