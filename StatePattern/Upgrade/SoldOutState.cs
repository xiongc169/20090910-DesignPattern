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
    /// 售完状态
    /// </summary>
    public class SoldOutState : IState
    {
        GumballMachineUpgrade gumballMachine;

        public SoldOutState(GumballMachineUpgrade machine)
        {
            this.gumballMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You cannot insert a quarter,the machine is sold out!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("you cannot eject,you haven't inserted a quarter yet!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned,but there are no gumballs!");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispense!");
        }
    }
}
