/***********************************************************************************************************************************
 * 
 * 功能：饮料类
 * 
 * 作者：
 * 
 * 时间：
 * 
 * 参考：
 * 
 * 备注：抽象组件
 * 
 ***********************************************************************************************************************************/

namespace DecoratorDemo.Abstract
{
    /// <summary>
    /// 饮料类
    /// </summary>
    public abstract class Beverage
    {
        public string desc = "Unknown Beverage";

        public string GetDesc()
        {
            return desc;
        }

        public abstract double GetCost();
    }
}
