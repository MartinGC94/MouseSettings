using MouseSettings.Native;
using MouseSettings.PublicTypes;
using System.Management.Automation;

namespace MouseSettings.Commands
{
    [Cmdlet(VerbsCommon.Set, "MouseSettings")]
    public sealed class SetMouseSettingsCommand : PSCmdlet
    {
        #region parameters
        [Parameter()]
        public PrimaryButton PrimaryButton { get; set; }

        [Parameter()]
        public ScrollTargetBehavior ScrollTargetBehavior { get; set; }

        [Parameter()]
        [ValidateRange(1, 20)]
        public int Speed { get; set; }

        [Parameter()]
        public bool AccelerationEnabled { get; set; }

        [Parameter()]
        [ValidateRange(-1, int.MaxValue)]
        public int AccelerationSpeed { get; set; } = -1;

        [Parameter()]
        [ValidateRange(-1, int.MaxValue)]
        public int AccelerationThreshold1 { get; set; } = -1;

        [Parameter()]
        [ValidateRange(-1, int.MaxValue)]
        public int AccelerationThreshold2 { get; set; } = -1;

        [Parameter()]
        public bool SonarEnabled { get; set; }

        [Parameter()]
        public bool CursorHiddenWhenTyping { get; set; }

        [Parameter()]
        public bool CursorSnapsToDefaultButton { get; set; }

        [Parameter()]
        [ValidateRange(0, 16)]
        public int MouseTrails { get; set; }

        [Parameter()]
        public uint HorizontalScrollCharCount { get; set; }

        [Parameter()]
        //[ArgumentCompleter()] Add argument completer for "OneScreen"
        public uint VerticalScrollLineCount { get; set; }

        [Parameter()]
        public bool ClickLockEnabled { get; set; }

        [Parameter()]
        public uint ClickLockDelay { get; set; }

        [Parameter()]
        public uint HoverHeight { get; set; }

        [Parameter()]
        public uint HoverWidth { get; set; }

        [Parameter()]
        [ValidateRange(10, int.MaxValue)]
        public uint HoverDelayMs { get; set; }

        [Parameter()]
        public uint DoubleClickHeight { get; set; }

        [Parameter()]
        public uint DoubleClickWidth { get; set; }

        [Parameter()]
        [ValidateRange(0, 5000)]
        public uint DoubleClickDelayMs { get; set; }

        [Parameter()]
        [ValidateRange(1, uint.MaxValue)]
        public uint CursorSize { get; set; }
        #endregion

        protected override void EndProcessing()
        {
            foreach (var key in MyInvocation.BoundParameters.Keys)
            {
                switch (key)
                {
                    case "PrimaryButton":
                        SettingsHandler.SetPrimaryButton(PrimaryButton);
                        break;

                    case "ClickLockEnabled":
                        SettingsHandler.SetClickLockState(ClickLockEnabled);
                        break;

                    case "ClickLockDelay":
                        SettingsHandler.SetClickLockDelay(ClickLockDelay);
                        break;

                    case "SonarEnabled":
                        SettingsHandler.SetMouseSonarState(SonarEnabled);
                        break;

                    case "CursorHiddenWhenTyping":
                        SettingsHandler.SetMouseCursorHideWhenTypingState(CursorHiddenWhenTyping);
                        break;

                    case "Speed":
                        SettingsHandler.SetMouseSpeed(Speed);
                        break;

                    case "AccelerationEnabled":
                        SettingsHandler.SetMouseAccelerationState(AccelerationEnabled);
                        break;

                    case "HoverHeight":
                        SettingsHandler.SetMouseHoverHeight(HoverHeight);
                        break;

                    case "HoverWidth":
                        SettingsHandler.SetMouseHoverWidth(HoverWidth);
                        break;

                    case "HoverDelayMs":
                        SettingsHandler.SetMouseHoverDelay(HoverDelayMs);
                        break;

                    case "MouseTrails":
                        SettingsHandler.SetMouseTrailsValue(MouseTrails);
                        break;

                    case "ScrollTargetBehavior":
                        SettingsHandler.SetMouseScrollBehavior(ScrollTargetBehavior);
                        break;

                    case "CursorSnapsToDefaultButton":
                        SettingsHandler.SetMouseSnapToDefaultButtonState(CursorSnapsToDefaultButton);
                        break;

                    case "HorizontalScrollCharCount":
                        SettingsHandler.SetHorizontalScrollCharCount(HorizontalScrollCharCount);
                        break;

                    case "VerticalScrollLineCount":
                        SettingsHandler.SetVerticalScrollLineCount(VerticalScrollLineCount);
                        break;

                    case "DoubleClickHeight":
                        SettingsHandler.SetDoubleClickHeight(DoubleClickHeight);
                        break;

                    case "DoubleClickWidth":
                        SettingsHandler.SetDoubleClickWidth(DoubleClickWidth);
                        break;

                    case "DoubleClickDelayMs":
                        _ = NativeMethods.SetDoubleClickTime(DoubleClickDelayMs);
                        break;

                    case "CursorSize":
                        SettingsHandler.SetCursorSize(CursorSize);
                        break;

                    default:
                        break;
                }
            }

            if (MyInvocation.BoundParameters.ContainsKey("AccelerationSpeed") ||
                MyInvocation.BoundParameters.ContainsKey("AccelerationThreshold1") ||
                MyInvocation.BoundParameters.ContainsKey("AccelerationThreshold2"))
            {
                SettingsHandler.SetMouseAccelerationParameters(AccelerationSpeed, AccelerationThreshold1, AccelerationThreshold2);
            }
        }
    }
}