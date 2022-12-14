using MouseSettings.Native;
using MouseSettings.Native.user32Enums;
using MouseSettings.PublicTypes;

namespace MouseSettings
{
    internal class SettingsHandler
    {
        internal static PrimaryButton GetPrimaryButton()
        {
            return (PrimaryButton)NativeMethods.GetSystemMetrics(SystemMetricsIndex.SM_SWAPBUTTON);
        }

        internal static void SetPrimaryButton(PrimaryButton button)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSEBUTTONSWAP, (uint)button, null, UpdateFlags.SaveAndPublish);
        }

        internal static bool GetClickLockState()
        {
            bool enabled = false;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSECLICKLOCK, 0, ref enabled, UpdateFlags.DoNotPublish);
            return enabled;
        }

        internal static void SetClickLockState(bool enabled)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSECLICKLOCK, 0, enabled, UpdateFlags.SaveAndPublish);
        }

        internal static uint GetClickLockDelay()
        {
            uint delayInMs = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSECLICKLOCKTIME, 0, ref delayInMs, UpdateFlags.DoNotPublish);
            return delayInMs;
        }

        internal static void SetClickLockDelay(uint delay)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSECLICKLOCKTIME, 0, delay, UpdateFlags.SaveAndPublish);
        }

        internal static bool GetMouseSonarState()
        {
            bool enabled = false;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSESONAR, 0, ref enabled, UpdateFlags.DoNotPublish);
            return enabled;
        }

        internal static void SetMouseSonarState(bool enabled)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSESONAR, 0, enabled, UpdateFlags.SaveAndPublish);
        }

        internal static bool GetMouseCursorHideWhenTypingState()
        {
            bool enabled = false;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSEVANISH, 0, ref enabled, UpdateFlags.DoNotPublish);
            return enabled;
        }

        internal static void SetMouseCursorHideWhenTypingState(bool enabled)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSEVANISH, 0, enabled, UpdateFlags.SaveAndPublish);
        }

        internal static int GetMouseSpeed()
        {
            int speed = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSESPEED, 0, ref speed, UpdateFlags.DoNotPublish);
            return speed;
        }

        internal static void SetMouseSpeed(int speed)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSESPEED, 0, speed, UpdateFlags.SaveAndPublish);
        }

        internal static int[] GetMouseAccelerationParameters()
        {
            var values = new int[3];
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSE, 0, values, UpdateFlags.DoNotPublish);
            return values;
        }

        internal static void SetMouseAccelerationParameters(int accelerationSpeed, int accelerationThreshold1, int accelerationThreshold2)
        {
            int[] setParams;
            if (accelerationSpeed == -1 ||
                accelerationThreshold1 == -1 ||
                accelerationThreshold2 == -1)
            {
                setParams = GetMouseAccelerationParameters();
                if (accelerationThreshold1 != -1)
                {
                    setParams[0] = accelerationThreshold1;
                }
                if (accelerationThreshold2 != -1)
                {
                    setParams[1] = accelerationThreshold2;
                }
                if (accelerationSpeed != -1)
                {
                    setParams[2] = accelerationSpeed;
                }
            }
            else
            {
                setParams = new int[3]
                {
                    accelerationThreshold1,
                    accelerationThreshold2,
                    accelerationSpeed
                };
            }

            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSE, 0, setParams, UpdateFlags.SaveAndPublish);
        }

        internal static void SetMouseAccelerationState(bool enabled)
        {
            if (enabled)
            {
                SetMouseAccelerationParameters(1, 6, 10);
            }
            else
            {
                SetMouseAccelerationParameters(0, 0, 0);
            }
        }

        internal static uint GetMouseHoverHeight()
        {
            uint height = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSEHOVERHEIGHT, 0, ref height, UpdateFlags.DoNotPublish);
            return height;
        }

        internal static void SetMouseHoverHeight(uint height)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSEHOVERHEIGHT, height, null, UpdateFlags.SaveAndPublish);
        }

        internal static uint GetMouseHoverWidth()
        {
            uint width = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSEHOVERWIDTH, 0, ref width, UpdateFlags.DoNotPublish);
            return width;
        }

        internal static void SetMouseHoverWidth(uint width)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSEHOVERWIDTH, width, null, UpdateFlags.SaveAndPublish);
        }

        internal static uint GetMouseHoverDelay()
        {
            uint delayInMs = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSEHOVERTIME, 0, ref delayInMs, UpdateFlags.DoNotPublish);
            return delayInMs;
        }

        internal static void SetMouseHoverDelay(uint delayInMs)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSEHOVERTIME, delayInMs, null, UpdateFlags.SaveAndPublish);
        }

        internal static int GetMouseTrailsValue()
        {
            int mouseTrailCursors = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSETRAILS, 0, ref mouseTrailCursors, UpdateFlags.DoNotPublish);
            return mouseTrailCursors;
        }

        internal static void SetMouseTrailsValue(int mouseTrailCursors)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSETRAILS, (uint)mouseTrailCursors, null, UpdateFlags.SaveAndPublish);
        }

        internal static ScrollTargetBehavior GetMouseScrollBehavior()
        {
            uint behavior = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETMOUSEWHEELROUTING, 0, ref behavior, UpdateFlags.DoNotPublish);
            return (ScrollTargetBehavior)behavior;
        }

        internal static void SetMouseScrollBehavior(ScrollTargetBehavior behavior)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETMOUSEWHEELROUTING, 0, (uint)behavior, UpdateFlags.SaveAndPublish);
        }

        internal static bool GetMouseSnapToDefaultButtonState()
        {
            bool enabled = false;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETSNAPTODEFBUTTON, 0, ref enabled, UpdateFlags.DoNotPublish);
            return enabled;
        }

        internal static void SetMouseSnapToDefaultButtonState(bool enabled)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETSNAPTODEFBUTTON, enabled, null, UpdateFlags.SaveAndPublish);
        }

        internal static uint GetHorizontalScrollCharCount()
        {
            uint charCount = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETWHEELSCROLLCHARS, 0, ref charCount, UpdateFlags.DoNotPublish);
            return charCount;
        }

        internal static void SetHorizontalScrollCharCount(uint charCount)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETWHEELSCROLLCHARS, charCount, null, UpdateFlags.SaveAndPublish);
        }

        internal static uint GetVerticalScrollLineCount()
        {
            uint lineCount = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_GETWHEELSCROLLLINES, 0, ref lineCount, UpdateFlags.DoNotPublish);
            return lineCount;
        }

        internal static void SetVerticalScrollLineCount(uint lineCount)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETWHEELSCROLLLINES, lineCount, null, UpdateFlags.SaveAndPublish);
        }

        internal static int GetDoubleClickHeight() => NativeMethods.GetSystemMetrics(SystemMetricsIndex.SM_CYDOUBLECLK);

        internal static void SetDoubleClickHeight(uint height)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETDOUBLECLKHEIGHT, height, null, UpdateFlags.SaveAndPublish);
        }

        internal static int GetDoubleClickWidth() => NativeMethods.GetSystemMetrics(SystemMetricsIndex.SM_CXDOUBLECLK);

        internal static void SetDoubleClickWidth(uint width)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SPI_SETDOUBLECLKWIDTH, width, null, UpdateFlags.SaveAndPublish);
        }

        internal static uint GetCursorSize()
        {
            uint size = 0;
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.GetCursorSize, 0, ref size, UpdateFlags.DoNotPublish);
            return size;
        }

        internal static void SetCursorSize(uint size)
        {
            _ = NativeMethods.SystemParametersInfo(SystemParametersAction.SetCursorSize, 0, size, UpdateFlags.SaveAndPublish);
        }
    }
}