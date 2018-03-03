/***********************************************************************************************************************************
 * 
 * 功能：设计模式——状态模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-29
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace StatePattern.Upgrade
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 状态接口，所有的状态都必须实现这个接口
    /// </summary>
    public interface IState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrank();

        void Dispense();
    }
}
