/***********************************************************************************************************************************
 * 
 * 功能：设计模式——桥接模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-8
 * 
 * 参考：
 * 
 * 备注：
 * http://www.cnblogs.com/houleixx/archive/2008/02/23/1078877.html
 * 区别桥接模式、装饰模式异同；
 * 
 ***********************************************************************************************************************************/

namespace BridgeDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BridgeDemo.Implements;
    using BridgeDemo.Interfaces;

    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car();
            car.SetType();

            IRoad speedway = new SpeedWay();
            speedway.Car = car;
            speedway.Desc();

            Console.ReadKey(true);
        }
    }
}
