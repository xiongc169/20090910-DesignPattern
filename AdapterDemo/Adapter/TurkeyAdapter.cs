/***********************************************************************************************************************************
 * 
 * 功能：设计模式——适配器模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-23
 * 
 * 参考：
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace AdapterDemo.Adapter
{
    using AdapterDemo.Interfaces;

    /// <summary>
    /// 火鸡适配器
    /// 缺少鸭子，需要用火鸡来冒充；
    /// A、首先需要实现想转换成的类型接口
    /// </summary>
    public class TurkeyAdapter : IDuck
    {
        private ITurkey iTurkey;

        /// <summary>
        /// 构造函数
        /// B、获取要适配的对象引用
        /// </summary>
        /// <param name="ITurkey"></param>
        public TurkeyAdapter(ITurkey ITurkey)
        {
            iTurkey = ITurkey;
        }

        /// <summary>
        /// 实现接口中的所有方法
        /// C、方法转换
        /// </summary>
        public void Quack()
        {
            iTurkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                iTurkey.Fly();
            }
        }
    }
}
