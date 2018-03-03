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
 * 
 ***********************************************************************************************************************************/

namespace MementoDemo.Implements
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 发起人：记录当前时刻的内部状态，负责定义哪些属于备份范围的状态，负责创建和恢复备忘录数据。
    /// </summary>
    public class Originator
    {
        public string State = "";

        public Memento CreateMemento(string state)
        {
            return new Memento(state);
        }

        public void RestoreMemento(Memento memento)
        {
            this.State = memento.State;
        }
    }
}
