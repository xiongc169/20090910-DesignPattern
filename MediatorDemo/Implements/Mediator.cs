/***********************************************************************************************************************************
 * 
 * 功能：设计模式——中介者模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-16
 * 
 * 参考：
 * 
 * 备注：http://www.cnblogs.com/zxj159/p/3466115.html#top
 * 
 ***********************************************************************************************************************************/

namespace MediatorDemo.Implements
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MediatorDemo.Interfaces;

    /// <summary>
    /// 中介者
    /// </summary>
    public class Mediator : IMediator
    {
        public override void Change(IColleague colleague)
        {
            if (colleague.GetType() == typeof(ColleagueA))
            {
                Console.WriteLine("ColleagueA is Changing....");
            }

            if (colleague.GetType() == typeof(ColleagueA))
            {
                Console.WriteLine("ColleagueB is Changing....");
            }
        }
    }
}
