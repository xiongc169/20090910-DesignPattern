/***********************************************************************************************************************************
 * 
 * 功能：设计模式——单例模式
 * 
 * 作者：
 * 
 * 时间：
 * 
 * 参考：与ThreadPool类相似，注意其中volatile关键字的用法
 * 
 * 备注：
 * http://www.cnblogs.com/BoyXiao/archive/2010/05/07/1729376.html?login=1
 * 
 * 不要混淆全局变量、单例模式：
 * 
 * 
 ***********************************************************************************************************************************/

namespace SingletonDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        //定义一个私有静态全局变量，用以保存该类的唯一实例
        private static Singleton singleton = null;

        /// <summary>
        /// 定义一个静态的只读对象
        /// 由于提供给 lock 关键字的参数必须为基于引用类型的对象，该对象用来定义锁的范围
        /// </summary>
        private static readonly object syncObject = new object();

        /// <summary>
        /// 构造函数，私有的
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// 定义一个全局访问点；
        /// 首先这个 Singleton 类会在在第一次调用 GetInstance()时创建一个实例，并将这个实例的引用封装在自身类中，
        /// 然后以后调用 GetInstance()时就会判断这个 Singleton 是否存在一个实例了，如果存在，则不会再创建实例。
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            //多线程情况下，本单例模式也有可能会创建多个实例；
            //解决之道：线程锁定
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }

        /// <summary>
        /// 单例模式
        /// 懒汉式单例模式：单例类的这个唯一实例是在第一次使用 GetInstance（）时实例化的，
        /// 如果不调用 GetInstance（）的话，这个实例是不会存在的，即为 null；
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstanceLock()
        {
            //双重检查锁定(出于安全、性能考虑)
            if (singleton == null)
            {
                lock (syncObject)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton();
                    }
                }
            }
            return singleton;
        }

        #region 饿汉式单例模式

        /// <summary>
        /// 饿汉式单例模式： 不需要别人来催他实例化单例类的唯一实例，自己会主动实例化单例类的唯一实例；
        /// 在 C# 中，可以用特殊的方式实现饿汉式单例，即使用静态初始化来完成饿汉式单例模式。
        /// 
        /// 这里使用静态初始化，无需显示地编写线程安全代码，C# 与 CLR 会自动解决前面提到的懒汉式单例类时出现的多线程同步问题。
        /// </summary>
        private static readonly Singleton SingletonB = new Singleton();

        /// <summary>
        /// 饿汉式单例模式
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstanceB()
        {
            return SingletonB;
        } 

        #endregion
    }
}
