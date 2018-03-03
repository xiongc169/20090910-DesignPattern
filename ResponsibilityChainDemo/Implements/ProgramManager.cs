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
    /// 具体处理者——项目经理类
    /// </summary>
    public class ProgramManager : IBoss
    {
        public override HolidayRequest CheckHoliday(HolidayRequest requests)
        {
            if (requests.Days <= 0.5)
            {
                requests.Reply = "ProgramManager YES!";
                return requests;
            }
            return Successor.CheckHoliday(requests);
        }
    }
}
