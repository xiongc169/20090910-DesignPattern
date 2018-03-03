/***********************************************************************************************************************************
 * 
 * 功能：设计模式——单例模式
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

namespace SingletonDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 线程池
    /// </summary>
    public class ThreadPool
    {
        private volatile static ThreadPool uniqueInstance = null;

        /// <summary>
        /// 构造函数，私有的
        /// </summary>
        private ThreadPool()
        { }

        /// <summary>
        /// 获取实例方法，公开的；
        /// </summary>
        /// <returns></returns>
        public static ThreadPool GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new ThreadPool();
            }
            return uniqueInstance;
        }
    }
}
