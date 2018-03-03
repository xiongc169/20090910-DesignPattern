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

namespace BuilderDemo.Implements
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BuilderDemo.Entities;
    using BuilderDemo.Interface;

    /// <summary>
    /// 指导者类：
    /// 调用具体建造者角色以创建产品对象
    /// </summary>
    public class Director
    {
        public Product Construct(IBuilder builder)
        {
            builder.BuildPartOne();
            builder.BuildPartTwo();
            return builder.ReturnProduct();
        }
    }
}
