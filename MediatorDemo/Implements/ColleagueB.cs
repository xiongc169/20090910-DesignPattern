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
    /// 同事B
    /// </summary>
    public class ColleagueB : IColleague
    {
        public ColleagueB(IMediator mediator)
            : base(mediator)
        {
        }

        public void OperationB()
        {
            base.GetMediator().Change(this);
        }
    }
}
