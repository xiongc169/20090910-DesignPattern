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
    using System.Collections;

    /// <summary>
    /// 煎饼屋菜单实现
    /// </summary>
    public class PanCakeHouseMenu
    {
        private ArrayList menuItems;

        public PanCakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("K&B Pancake", "K&B Pancake Description", true, 2.99);
            AddItem("Regular Pancake", "Regular Pancake Description", false, 2.99);
            AddItem("Bluebarry Pancake", "Bluebarry Pancake Description", true, 3.49);
            AddItem("Waffles Pancake", "Waffles Pancake Description", true, 3.59);
        }

        public void AddItem(string name, string desc, bool isVegetarian, double price)
        {
            MenuItem item = new MenuItem(name, desc, isVegetarian, price);
            menuItems.Add(item);
        }

        public ArrayList GetMenuItems()
        {
            return this.menuItems;
        }
    }
}
