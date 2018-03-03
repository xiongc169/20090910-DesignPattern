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
    /// 管理角色：对备忘录进行管理，保存和提供备忘录。
    /// </summary>
    public class Caretaker
    {
        public Memento Memento;
    }
}
