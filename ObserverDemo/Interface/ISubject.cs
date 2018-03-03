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
 * 备注：被监听对象
 * 
 ***********************************************************************************************************************************/

namespace ObserverDemo.Interface
{
    /// <summary>
    ///出版者（主题对象，Subject）
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObserver();
    }
}
