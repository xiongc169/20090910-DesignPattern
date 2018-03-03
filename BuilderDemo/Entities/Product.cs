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

namespace BuilderDemo.Entities
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 产品类
    /// </summary>
    public class Product
    {
        private ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach (string item in parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
