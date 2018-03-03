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
 * http://www.cnblogs.com/wangjq/archive/2012/07/12/2587966.html
 * 一对多的依赖关系，多个观察者对象(Observer)同时监听一个主题对象(Subject)
 * 
 ***********************************************************************************************************************************/

namespace ObserverDemo
{
    using System;
    using Observer;
    using Subject;

    /// <summary>
    /// 出版者（主题，Subject）+订阅者（观察者，Observer）=观察者模式；
    /// </summary>
    class Program
    {
        public static EventHandler handler = null;

        static void Main(string[] args)
        {
            //事件测试
            AddEvent();
            if (handler != null)
            {
                handler(new object(), new EventArgs());
            }

            WeatherData weatherData = new WeatherData();
            BillboardAHNU ahnu = new BillboardAHNU();
            weatherData.SetDes(DateTime.Now, "Cloudy", "Poor");

            weatherData.RegisterObserver(ahnu);
            weatherData.SetDes(DateTime.Now.AddDays(2), "Sunny", "Good");

            weatherData.RemoveObserver(ahnu);
            weatherData.SetDes(DateTime.Now.AddDays(10), "Sunny", "Good");

            Console.ReadKey(true);
        }

        public static void AddEvent()
        {
            handler += Report;
        }

        public static void Report(object sender, EventArgs e)
        {
            Console.WriteLine("this is Report!!!");
        }
    }
}
