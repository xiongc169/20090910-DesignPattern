/***********************************************************************************************************************************
 * 
 * 功能：设计模式——命令模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-9-22
 * 
 * 参考：
 * 
 * 备注：
 * http://www.cnblogs.com/BoyXiao/archive/2010/05/08/1730250.html
 * 解耦行为请求者、行为执行者；
 * 
 ***********************************************************************************************************************************/

namespace CommandDemo
{
    using System;
    using Entities;
    using Implements;

    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey(true);
        }

        static void Test()
        {
            Light light = new Light();
            Console.WriteLine("Former Status {0}", light.Status);
            LightOnCmd lightOnCmd = new LightOnCmd(light);
            RemoteControl remoteControl = new RemoteControl(lightOnCmd);
            remoteControl.BtnPressed();
            Console.WriteLine("Latter Status {0}", light.Status);
        }
    }
}
