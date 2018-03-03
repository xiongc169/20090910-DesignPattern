/***********************************************************************************************************************************
 * 
 * 功能：设计模式——责任链模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-12
 * 
 * 参考：
 * 
 * 备注：http://www.cnblogs.com/kym/archive/2009/04/06/1430078.html
 * 请假的例子：
 * 1、灵活改变内部传递规则，动态指定继任者；
 * 2、可以从职责链任何一关开始；
 * 
 * 职责链不同于链表：可以访问职责链中的任何一个节点作为开始节点；
 * 
 * 职责链的扩展——树状链结构，每个节点都可以使用一个List来维护他的继任节点，甚至可以用组合模式来分别设计每一节点；
 * 树状链结构中，可以添加兜底条款，
 * 
 * 职责链的缺点：当这个链结构比较长，比较复杂的话，会产生很多的内存垃圾对象。
 * 
 * 表驱动(Table Driven)改进职责链：用查表的方式来获取值；
 * 
 * http://www.cnblogs.com/java-my-life/archive/2012/05/28/2516865.html
 * 申请聚餐费用：
 * 责任链涉及角色：抽象处理者角色、具体处理者角色；
 * 
 * 责任链模式在Tomcat中的应用：
 * 
 ***********************************************************************************************************************************/

namespace ResponsibilityChainDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ResponsibilityChainDemo.Implements;

    class Program
    {
        static void Main(string[] args)
        {
            ResponsibilityTest();
            Console.ReadKey(true);
        }

        /// <summary>
        /// 责任链模式-请假Demo练习
        /// </summary>
        static void ResponsibilityTest()
        {
            HolidayRequest request = new HolidayRequest(0.5, "Normal");

            ProgramManager pm = new ProgramManager();
            HumanRes hr = new HumanRes();
            Manager mgr = new Manager();

            //动态指定继任者
            pm.Successor = hr;
            hr.Successor = mgr;

            request = pm.CheckHoliday(request);

            //可以从职责链任何一关开始
            request = mgr.CheckHoliday(request);
            Console.WriteLine(request.Reply);
        }
    }
}
