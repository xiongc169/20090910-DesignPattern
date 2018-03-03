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
    /// 具体制造者
    /// </summary>
    public class ConcreteBuilderA : IBuilder
    {
        Product productA = new Product();

        public override void BuildPartOne()
        {
            productA.Add("ProductA Part One");
        }

        public override void BuildPartTwo()
        {
            productA.Add("ProductA Part Two");
        }

        public override Product ReturnProduct()
        {
            return productA;
        }
    }
}
