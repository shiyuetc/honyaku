using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace honyaku
{
    /// <summary>
    /// Windows API
    /// </summary>
    public class WindowsAPI
    {
        /// <summary>
        /// マウス座標にあるハンドルを取得する
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point point);

        /// <summary>
        /// 指定したハンドルからのアプリケーションにフォーカスを与える
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
