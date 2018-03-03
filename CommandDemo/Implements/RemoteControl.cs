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

using CommandDemo.Interfaces;

namespace CommandDemo.Implements
{
    /// <summary>
    /// 遥控器类
    /// </summary>
    public class RemoteControl
    {
        private ICommand slot;

        public RemoteControl()
        { }

        public RemoteControl(ICommand iCmd)
        {
            slot = iCmd;
        }

        public void BtnPressed()
        {
            slot.Execute();
        }
    }
}
