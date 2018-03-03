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
 * 
 ***********************************************************************************************************************************/

using CommandDemo.Entities;
using CommandDemo.Interfaces;

namespace CommandDemo.Implements
{
    /// <summary>
    /// 电灯的命令
    /// </summary>
    public class LightOnCmd : ICommand
    {
        private Light _light;

        public LightOnCmd(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.Status = true;
        }
    }
}
