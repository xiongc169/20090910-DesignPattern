/***********************************************************************************************************************************
 * 
 * 功能：设计模式之单例模式
 * 
 * 作者：
 * 
 * 时间：2014-08-19
 * 
 * 参考：声纹采集终端单例模式
 * 
 * 备注：
 * 
 ***********************************************************************************************************************************/

namespace SingletonDemo
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    /// <summary>
    /// Utility class for App
    /// </summary>
    public sealed class ProgramHelper
    {

        /// <summary>
        /// 定义WindowForm Closing的Source
        /// </summary>
        public enum ClosingSource
        {
            /// <summary>
            /// We've never seen this one before!!!
            /// </summary>
            Unknown = -1,
            /// <summary>
            /// Shutdown from a call to this.Close();
            /// </summary>
            Code = 0,
            /// <summary>
            /// Shutdown from the task manager. 
            /// </summary>
            TaskManager = 1,
            /// <summary>
            /// Windows is shutting down, or user logging out.
            /// </summary>
            SystemShutdown = 2,
            /// <summary>
            /// User selected by clicking "X" in form, or from the control menu.
            /// </summary>
            FormControlMenu = 3
        }

        /// <summary>
        /// 检查当前的应用程序的Config文件是否存在
        /// 如：应用程序为xxx.exe，则配置文件在同目录下xxx.exe.config
        /// </summary>
        /// <returns></returns>
        public bool WinAppConfigExists()
        {
            string sPath = Assembly.GetEntryAssembly().Location + ".config";
            return File.Exists(sPath);
        }

        /// <summary>
        /// 获取关装当前窗体的Source
        /// 关闭当前的Window有很多方法，如：Message,关机消息，快捷键等。
        /// </summary>
        /// <param name="stack">关闭时的程序堆栈</param>
        /// <returns>
        /// 返回关闭窗体的Source 枚举
        /// </returns>
        public ClosingSource GetClosingSource(StackTrace stack)
        {
            StackFrame frame7 = stack.GetFrame(7);
            ClosingSource closeSrc = ClosingSource.Unknown;
            switch (frame7.GetMethod().Name)
            {
                case "SendMessage":
                    closeSrc = ClosingSource.Code;
                    break;
                case "DispatchMessageW":
                    closeSrc = ClosingSource.TaskManager;
                    break;
                case "CallWindowProc":
                    //At frame 7, a close due to system shutdown still looks
                    //like a user-selected shutdown, so we have to check the
                    //next change, which is at stack position 14.
                    StackFrame frame14 = stack.GetFrame(14);
                    if (frame14.GetMethod().Name == "WndProc")
                    {
                        closeSrc = ClosingSource.SystemShutdown;
                    }
                    else
                    {
                        if (frame14.GetMethod().Name == "WmSysCommand")
                        {
                            closeSrc = ClosingSource.FormControlMenu;
                        }
                    }
                    break;
            }

            return closeSrc;
        }

        /// <summary>
        /// 判断当前的win应用程序实例是否已经运行
        /// 如果没有运行返回true,已经运行，返回false
        /// </summary>
        /// <returns></returns>
        public static bool SingleRunWinApp()
        {
            SingleInstanceAppHelper helper = new SingleInstanceAppHelper();
            return helper.SingleRunWinApp();
        }

        /// <summary>
        /// 判断当前的Console应用程序实例是否已经运行
        /// 如果没有运行返回true,已经运行，返回false
        /// </summary>
        /// <returns></returns>
        public bool SingleRunConsoleApp()
        {
            SingleInstanceAppHelper helper = new SingleInstanceAppHelper();
            return helper.SingleRunConsoleApp();
        }
    }

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class SingleInstanceAppHelper
    {
        /// <summary>
        /// define program mutex
        /// </summary>
        private static Mutex programMutex;

        #region Private Methods
        /// <summary>
        /// GetCurrentInstanceWindowHandle
        /// </summary>
        /// <returns></returns>
        private IntPtr GetCurrentInstanceWindowHandle()
        {
            IntPtr hWnd = IntPtr.Zero;
            Process process = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(process.ProcessName);
            foreach (Process _process in processes)
            {
                // Get the first instance that is not this instance, has the
                // same process name and was started from the same file name
                // and location. Also check that the process has a valid
                // window handle in this session to filter out other user's
                // processes.
                if (_process.Id != process.Id &&
                    _process.MainModule.FileName == process.MainModule.FileName &&
                    _process.MainWindowHandle != IntPtr.Zero)
                {
                    hWnd = _process.MainWindowHandle;
                    break;
                }
            }
            return hWnd;
        }

        /// <summary>
        /// SwitchToCurrentInstance
        /// </summary>
        private void SwitchToCurrentInstance()
        {
            IntPtr hWnd = GetCurrentInstanceWindowHandle();
            if (hWnd != IntPtr.Zero)
            {
                //// Restore window if minimised. Do not restore if already in
                //// normal or maximised window state, since we don't want to
                //// change the current state of the window.
                //if (User32.IsIconic(hWnd) != 0)
                //{
                //    User32.ShowWindow(hWnd, SW.RESTORE);
                //}

                //// Set foreground window.
                //User32.SetForegroundWindow(hWnd);
            }
        }

        /// <summary>
        /// check if given exe alread running or not
        /// </summary>
        /// <returns>returns true if already running</returns>
        private bool IsAlreadyRunning()
        {
            string strLoc = Assembly.GetEntryAssembly().Location;
            FileSystemInfo fileInfo = new FileInfo(strLoc);
            string sExeName = fileInfo.Name;
            bool bCreatedNew;

            programMutex = new Mutex(true, "Global\\" + sExeName, out bCreatedNew);
            if (bCreatedNew)
                programMutex.ReleaseMutex();

            return !bCreatedNew;
        }
        #endregion

        /// <summary>
        /// Execute a form base application if another instance already running on
        /// the system activate previous one
        /// </summary>
        /// <param name="frmMain">main form</param>
        /// <returns>true if no previous instance is running</returns>
        public bool SingleRunWinApp()
        {
            if (IsAlreadyRunning())
            {
                //set focus on previously running app                
                SwitchToCurrentInstance();
                return false;
            }
            return true;
        }

        /// <summary>
        /// for console base application
        /// </summary>
        /// <returns></returns>
        public bool SingleRunConsoleApp()
        {
            if (IsAlreadyRunning())
            {
                return false;
            }
            return true;
        }
    }
}
