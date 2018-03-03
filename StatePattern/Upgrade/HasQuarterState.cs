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
    public class HasQuarterState : IState
    {
        GumballMachineUpgrade gumballMachine;

        public HasQuarterState(GumballMachineUpgrade machine)
        {
            this.gumballMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cannot insert another quarter!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned!");
            gumballMachine.SetState(gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.SetState(gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed!");
        }
    }
}
