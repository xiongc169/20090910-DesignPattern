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
    public class WinnerState : IState
    {
        public GumballMachineUpgrade gumballMachine;

        public WinnerState(GumballMachineUpgrade machine)
        {
            this.gumballMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("");
        }

        public void TurnCrank()
        {
            Console.WriteLine("");
        }

        public void Dispense()
        {
            Console.WriteLine("You are winner!You get twice gumball for your quarter!");
            gumballMachine.ReleaseBall();
            if (gumballMachine.Count == 0)
            {
                gumballMachine.SetState(gumballMachine.SoldOutState);
            }
            else
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
}
