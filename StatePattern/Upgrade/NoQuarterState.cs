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
    /// 
    /// </summary>
    public class NoQuarterState : IState
    {
        private GumballMachineUpgrade gumballMachine;

        public NoQuarterState(GumballMachineUpgrade machine)
        {
            this.gumballMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter!");
            gumballMachine.SetState(gumballMachine.HasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You havn't inserted a quarter!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned,but there is no quarter!");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first!");
        }
    }
}
