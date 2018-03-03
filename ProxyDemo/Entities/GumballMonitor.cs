/***********************************************************************************************************************************
 * 
 * 功能：设计模式——代理模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-30(It's a happy day,isn't is?)
 * yes,the holiday is coming 2016-3-13 13:31:05
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace ProxyDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using StatePattern.Upgrade;

    /// <summary>
    /// 糖果机监视器
    /// </summary>
    public class GumballMonitor
    {
        GumballMachineUpgrade gumballMachine;

        public GumballMonitor(GumballMachineUpgrade machine)
        {
            this.gumballMachine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine :{0}", gumballMachine.Location);
            Console.WriteLine("Current Inventory :{0} Gumballs", gumballMachine.Count);
            Console.WriteLine("Current State :{0}", gumballMachine.CurrentState);
        }
    }
}
