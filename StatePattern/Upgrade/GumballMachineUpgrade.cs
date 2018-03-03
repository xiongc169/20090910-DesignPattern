/***********************************************************************************************************************************
 * 
 * 功能：设计模式——状态模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-27
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

using System.Security.Policy;

namespace StatePattern.Upgrade
{
    using System;

    /// <summary>
    /// 糖果机升级类
    /// </summary>
    public class GumballMachineUpgrade
    {
        public IState SoldOutState;
        public IState NoQuarterState;
        public IState HasQuarterState;
        public IState SoldState;
        public IState WinnerState;

        public int Count = 0;
        public IState CurrentState;

        public string Location;

        public GumballMachineUpgrade(string location, int cnt)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);

            CurrentState = SoldOutState;
            Count = cnt;
            Location = location;
            if (Count > 0)
            {
                CurrentState = NoQuarterState;
            }
        }

        /// <summary>
        /// 投入money
        /// </summary>
        public void InsertQuarter()
        {
            CurrentState.InsertQuarter();
        }

        /// <summary>
        /// 退回money
        /// </summary>
        public void EjectQuarter()
        {
            CurrentState.EjectQuarter();
        }

        /// <summary>
        /// 转动手柄
        /// </summary>
        public void TurnCrank()
        {
            CurrentState.TurnCrank();
        }

        /// <summary>
        /// 发放糖果
        /// </summary>
        public void Dispense()
        {
            CurrentState.TurnCrank();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newState"></param>
        public void SetState(IState newState)
        {
            CurrentState = newState;
        }

        /// <summary>
        /// 
        /// </summary>
        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }
    }
}
