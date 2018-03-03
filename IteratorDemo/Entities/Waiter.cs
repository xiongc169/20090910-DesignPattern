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
    /// 服务生类
    /// </summary>
    public class Waiter
    {
        PanCakeHouseMenu panCakeHouseMenu = new PanCakeHouseMenu();

        DinerMenu dinerMenu = new DinerMenu();

        private ArrayList breakfastList;

        private MenuItem[] lunchList;

        public Waiter()
        {
            breakfastList = panCakeHouseMenu.GetMenuItems();
            lunchList = dinerMenu.GetMenuItems();
        }

        public void PrintBreakfast()
        {
            for (int i = 0; i < breakfastList.Count; i++)
            {
                MenuItem item = (MenuItem)breakfastList[i];
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Desc);
                Console.WriteLine(item.IsVegetarian);
                Console.WriteLine(item.Price);
            }
        }

        public void PrintLunch()
        {
            for (int i = 0; i < lunchList.Length; i++)
            {
                MenuItem item = lunchList[i];
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Desc);
                Console.WriteLine(item.IsVegetarian);
                Console.WriteLine(item.Price);
            }
        }

        //注意：此处处理两个菜单，需要用两个循环遍历，如果更多菜单该如何解决？
        public void Print()
        {
            IEnumerator breakfastIEnumerator = breakfastList.GetEnumerator();
            while (breakfastIEnumerator.MoveNext())
            {
                MenuItem item = (MenuItem)breakfastIEnumerator.Current;
            }

            IEnumerator lunchIEnumerator = lunchList.GetEnumerator();
            while (lunchIEnumerator.MoveNext())
            {
                MenuItem item = (MenuItem)lunchIEnumerator.Current;
            }
        }
    }
}
