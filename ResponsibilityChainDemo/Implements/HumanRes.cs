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
    using ResponsibilityChainDemo.Interfaces;

    /// <summary>
    /// 具体处理者——人力资源部类
    /// </summary>
    public class HumanRes : IBoss
    {
        public override HolidayRequest CheckHoliday(HolidayRequest requests)
        {
            if (requests.Days <= 2)
            {
                requests.Reply = "HumanResource YES!";
                return requests;
            }
            return Successor.CheckHoliday(requests);
        }
    }
}
