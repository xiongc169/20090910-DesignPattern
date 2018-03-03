/***********************************************************************************************************************************
 * 
 * 功能：设计模式——观察者模式(出版者、订阅者)
 * 
 * 作者：
 * 
 * 时间：
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace ObserverDemo.Observer
{
    using System;
    using Interface;

    /// <summary>
    /// 订阅者
    /// </summary>
    public class BillboardAHNU : IObserver
    {
        private DateTime date;

        private string weather;

        private string mode;

        public void Update(DateTime date, string weather, string mode)
        {
            this.date = date;
            this.weather = weather;
            this.mode = mode;

            Console.WriteLine("今天是{0}，天气状况{1}，心情{2}", this.date, this.weather, this.mode);
        }
    }
}
