using System.Runtime.InteropServices;
using MouseSettings.Native.user32Enums;

namespace MouseSettings.Native
{
    internal class NativeMethods
    {
        #region SystemParametersInfo
        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            [In] object pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] bool uiParam,
            [In] object pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            [In] bool pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            ref bool pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            ref uint pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            [In] uint pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            [In] int pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            ref int pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern bool SystemParametersInfo(
            [In] SystemParametersAction uiAction,
            [In] uint uiParam,
            [In] int[] pvParam,
            [In] UpdateFlags fWinIni
        );

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(
            [In] SystemMetricsIndex nIndex
        );
        #endregion

        [DllImport("user32.dll")]
        public static extern uint GetDoubleClickTime();

        [DllImport("user32.dll")]
        public static extern bool SetDoubleClickTime([In] uint delayInMs);
    }
}