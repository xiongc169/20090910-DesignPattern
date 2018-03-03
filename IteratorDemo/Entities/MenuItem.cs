/***********************************************************************************************************************************
 * 
 * 功能：设计模式——迭代器模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-25
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace IteratorDemo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 菜单类
    /// </summary>
    public class MenuItem
    {
        public string Name { get; set; }

        public string Desc { get; set; }

        public bool IsVegetarian { get; set; }

        public double Price { get; set; }

        public MenuItem(string name, string desc, bool isVegetarian, double price)
        {
            this.Name = name;
            this.Desc = desc;
            this.IsVegetarian = isVegetarian;
            this.Price = price;
        }
    }
}
