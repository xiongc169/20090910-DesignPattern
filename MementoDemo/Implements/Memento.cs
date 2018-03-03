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
    /// 备忘录：负责存储发起人对象的内部状态，在需要的时候提供发起人需要的内部状态。
    /// </summary>
    public class Memento
    {
        public string State = "";

        public Memento(string state)
        {
            this.State = state;
        }
    }
}
