/***********************************************************************************************************************************
 * 
 * 功能：装饰者
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


namespace DecoratorDemo.Entities.BeveragePackge
{
    using Abstract;

    /// <summary>
    /// 深焙咖啡
    /// </summary>
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            desc = "DarkRoast";
        }

        public override double GetCost()
        {
            return 1.86;
        }
    }
}
