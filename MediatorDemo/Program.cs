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

namespace MediatorDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MediatorDemo.Implements;

    class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.ReadKey(true);
        }

        static void Test()
        {
            Mediator mediator = new Mediator();
            ColleagueA colleagueA = new ColleagueA(mediator);
            ColleagueB colleagueB = new ColleagueB(mediator);

            colleagueA.OperationA();
            colleagueB.OperationB();
        }
    }
}
