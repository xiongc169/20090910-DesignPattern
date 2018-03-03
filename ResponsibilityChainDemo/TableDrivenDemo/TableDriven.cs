/***********************************************************************************************************************************
 * 
 * 功能：设计模式——责任链模式
 * 
 * 作者：chaoxiong
 * 
 * 时间：2014-12-12
 * 
 * 参考：
 * 
 * 备注：http://www.cnblogs.com/kym/archive/2009/04/06/1430078.html
 * 请假的例子
 * 
 ***********************************************************************************************************************************/

namespace ResponsibilityChainDemo.TableDrivenDemo
{
    using System.Collections.Generic;

    /// <summary>
    /// 表驱动改进职责链
    /// </summary>
    public class TableDriven
    {
        private Dictionary<string, DBHelper> dic = new Dictionary<string, DBHelper>();

        public void Add(string name, DBHelper db)
        {
            dic.Add(name, db);
        }

        public DBHelper GetHelper(string name)
        {
            DBHelper helper;
            bool temp = dic.TryGetValue(name, out helper);
            if (temp)
            {
                return helper;
            }
            return null;
        }
    }

    public abstract class DBHelper
    {

    }
}
