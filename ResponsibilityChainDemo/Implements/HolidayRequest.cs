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

namespace ResponsibilityChainDemo.Implements
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 请假申请类
    /// </summary>
    public class HolidayRequest
    {
        public double Days;

        public string Reasons;

        public HolidayRequest(double days, string reasons)
        {
            this.Days = days;
            this.Reasons = reasons;
        }

        public string Reply;
    }
}
