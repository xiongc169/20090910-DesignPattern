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
    public class ConcreteBuilderB : IBuilder
    {
        Product productB = new Product();

        public override void BuildPartOne()
        {
            productB.Add("ProductB Part One");
        }

        public override void BuildPartTwo()
        {
            productB.Add("ProductB Part Two");
        }

        public override Product ReturnProduct()
        {
            return productB;
        }
    }
}
