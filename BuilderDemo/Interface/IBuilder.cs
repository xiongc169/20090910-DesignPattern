/***********************************************************************************************************************************
 * 
 * 功能：设计模式——建造者模式(生成器模式)
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-12
 * 
 * 参考：
 * 
 * 备注：
 * http://www.cnblogs.com/lds85930/articles/643143.html
 * 
 ***********************************************************************************************************************************/

namespace BuilderDemo.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BuilderDemo.Entities;

    /// <summary>
    /// 建造者接口：
    /// 包含建造方法、结果返回方法；
    /// </summary>
    public abstract class IBuilder
    {
        public abstract void BuildPartOne();

        public abstract void BuildPartTwo();

        public abstract Product ReturnProduct();
    }
}
