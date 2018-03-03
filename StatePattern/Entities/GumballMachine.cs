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
 * 第十章、状态模式，模拟糖果机的工作；
 * 
 ***********************************************************************************************************************************/

namespace StatePattern.Upgrade
{
    using System;

    /// <summary>
    /// 糖果机实现类
    /// </summary>
    public class GumballMachine
    {
        private const int SOLD_OUT = 0;

        private const int NO_QUARTER = 1;

        private const int HAS_QUARTER = 2;

        private const int SOLD = 3;

        private int CurrentState = SOLD_OUT;

        private int Count = 0;

        public GumballMachine(int cnt)
        {
            this.Count = cnt;
            if (this.Count > 0)
            {
                this.CurrentState = NO_QUARTER;
            }
        }

        /// <summary>
        /// 投入money
        /// </summary>
        public void InsertQuarter()
        {
            if (CurrentState == HAS_QUARTER)
            {
                Console.WriteLine("You cannot insert another quarter!");
            }
            else if (CurrentState == NO_QUARTER)
            {
                CurrentState = HAS_QUARTER;
                Console.WriteLine("You insert a quarter!");
            }
            else if (CurrentState == SOLD_OUT)
            {
                Console.WriteLine("You cannot insert a quarter,the machine is sold out!");
            }
            else if (CurrentState == SOLD)
            {
                Console.WriteLine("Please wait,we are already giving you a gumball!");
            }
        }

        /// <summary>
        /// 退回money
        /// </summary>
        public void EjectQuarter()
        {
            if (CurrentState == HAS_QUARTER)
            {
                CurrentState = NO_QUARTER;
                Console.WriteLine("Quarter returned!");
            }
            else if (CurrentState == NO_QUARTER)
            {
                Console.WriteLine("You havn't insert a quarter!");
            }
            else if (CurrentState == SOLD)
            {
                Console.WriteLine("Sorry,You already turned a crank!");
            }
            else if (CurrentState == SOLD_OUT)
            {
                Console.WriteLine("You can't eject,you have't insert a quarter yet!");
            }
        }

        /// <summary>
        /// 转动手柄
        /// </summary>
        public void TurnCrank()
        {
            if (CurrentState == SOLD)
            {
                Console.WriteLine("Turning twice doesn't get another gumball!");
            }
            else if (CurrentState == NO_QUARTER)
            {
                Console.WriteLine("You turned but there no quarter!");
            }
            else if (CurrentState == SOLD_OUT)
            {
                Console.WriteLine("You turned but there no gumball!");
            }
            else if (CurrentState == HAS_QUARTER)
            {
                Console.WriteLine("You turned......");
                CurrentState = SOLD;
                Dispense();
            }
        }

        /// <summary>
        /// 发放糖果
        /// </summary>
        public void Dispense()
        {
            if (CurrentState == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot!");
                Count--;
                if (Count == 0)
                {
                    CurrentState = SOLD_OUT;
                    Console.WriteLine("Out of gumballs!");
                }
                else
                {
                    CurrentState = NO_QUARTER;
                }
            }
            else if (CurrentState == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first!");
            }
            else if (CurrentState == SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed!");
            }
            else if (CurrentState == HAS_QUARTER)
            {
                Console.WriteLine("No gumball dispensed!");
            }
        }
    }
}
