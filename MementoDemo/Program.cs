/***********************************************************************************************************************************
 * 
 * 功能：设计模式——备忘录模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-16
 * 
 * 参考：
 * 
 * 备注：http://blog.csdn.net/zhengzhb/article/details/7697549
 * 通用代码实现；
 * 多状态多备份备忘录；
 * 
 ***********************************************************************************************************************************/

namespace MementoDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MementoDemo.Implements;

    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Originator类中的state变量需要备份，以便在需要的时候恢复；
        /// Memento类中，也有一个state变量，用来存储Originator类中state变量的临时状态；
        /// Caretaker类就是用来管理备忘录类的，用来向备忘录对象中写入状态或者取回状态。
        /// </summary>
        static void Test()
        {
            Originator originator = new Originator();
            Memento memento = new Memento("Ready");
            Caretaker caretaker = new Caretaker();

            memento.State = "Go";
            originator.RestoreMemento(memento);
        }
    }
}
