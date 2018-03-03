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

namespace MediatorDemo.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 中介者抽象类
    /// </summary>
    public abstract class IMediator
    {
        public abstract void Change(IColleague colleague);
    }
}
