/***********************************************************************************************************************************
 * 
 * 功能：设计模式——建造者模式(生成器模式)
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-12
 * 
 * 参考：
 * 
 * 备注：
 * http://www.cnblogs.com/lds85930/articles/643143.html
 * 建造者IBuilder(具体建造者)、指导者Director、产品Product；
 * 
 * 省略抽象建造者：若系统中只有一个具体建造者，可以省略抽象建造者；
 * 省略指导者：具体建造者只有一个时，若抽象建造者已省略，指导者也可以省略，让Builder扮指导者、建造者双重身份；C#中StringBuilder的例子；
 * 
 * 
 ***********************************************************************************************************************************/

namespace BuilderDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BuilderDemo.Implements;
    using BuilderDemo.Interface;

    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey(true);
        }

        /// <summary>
        /// 
        /// </summary>
        static void PrimaryTest()
        {
            IBuilder builderA = new ConcreteBuilderA();
            IBuilder builderB = new ConcreteBuilderB();
            Director director = new Director();

            director.Construct(builderA).Show();
            director.Construct(builderB).Show();
        }
    }
}
