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

namespace ObserverDemo.Subject
{
    using System;
    using System.Collections.Generic;
    using Interface;

    /// <summary>
    /// 出版者(主题对象)
    /// </summary>
    public class WeatherData : ISubject
    {
        private DateTime date;

        private string weather;

        private string mode;

        private List<IObserver> observers = null;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.IndexOf(observer) >= 0)
                observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(date, weather, mode);
            }
        }

        public void SetDes(DateTime date, string weather, string mode)
        {
            this.date = date;
            this.weather = weather;
            this.mode = mode;

            NotifyObserver();
        }
    }
}
