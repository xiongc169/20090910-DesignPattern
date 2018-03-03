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
    public class SoldState : IState
    {
        private GumballMachineUpgrade gumballMachine;

        public SoldState(GumballMachineUpgrade machine)
        {
            this.gumballMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait,we are already giving you a gumball!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry,you already turned the crank!");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.Count > 0)
            {
                gumballMachine.SetState(gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Out of gumballs!");
                gumballMachine.SetState(gumballMachine.SoldOutState);
            }
        }
    }
}
