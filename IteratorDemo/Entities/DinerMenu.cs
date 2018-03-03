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
    /// 餐厅菜单实现
    /// </summary>
    public class DinerMenu
    {
        private int MAX_ITEMS = 6;
        private int numOfItems = 0;
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("DinerMenu Item-1", "DinerMenu Item-1 Description", true, 2.99);
            AddItem("DinerMenu Item-2", "DinerMenu Item-2 Description", false, 2.99);
            AddItem("DinerMenu Item-3", "DinerMenu Item-3 Description", false, 3.29);
            AddItem("DinerMenu Item-4", "DinerMenu Item-4 Description", false, 3.05);
        }

        public void AddItem(string name, string desc, bool isVegetarian, double price)
        {
            MenuItem item = new MenuItem(name, desc, isVegetarian, price);
            if (numOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry,Menu is Full!");
            }
            else
            {
                menuItems[numOfItems] = item;
                numOfItems++;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return this.menuItems;
        }
    }
}
