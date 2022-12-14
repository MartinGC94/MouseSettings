using MouseSettings.Native;

namespace MouseSettings.PublicTypes
{
    public sealed class MouseSettings
    {
        public PrimaryButton PrimaryButton { get; private set; }
        public ScrollTargetBehavior ScrollTargetBehavior { get; private set; }        
        public int Speed { get; private set; }
        public bool AccelerationEnabled { get; private set; }
        public int AccelerationSpeed { get; private set; }
        public int AccelerationThreshold1 { get; private set; }
        public int AccelerationThreshold2 { get; private set; }
        public bool SonarEnabled { get; private set; }
        public bool CursorHiddenWhenTyping { get; private set; }
        public bool CursorSnapsToDefaultButton { get; private set; }
        public int MouseTrails { get; private set; }
        public uint HorizontalScrollCharCount { get; private set; }
        public uint VerticalScrollLineCount { get; private set; }
        public bool ClickLockEnabled { get; private set; }
        public uint ClickLockDelayMs { get; private set; }
        public uint HoverHeight { get; private set; }
        public uint HoverWidth { get; private set; }
        public uint HoverDelayMs { get; private set; }
        public int DoubleClickHeight { get; private set; }
        public int DoubleClickWidth { get; private set; }
        public uint DoubleClickDelayMs { get; private set; }
        public uint CursorSize { get; private set; }

        internal MouseSettings()
        {
            var accelerationParams = SettingsHandler.GetMouseAccelerationParameters();

            PrimaryButton = SettingsHandler.GetPrimaryButton();
            ClickLockEnabled = SettingsHandler.GetClickLockState();
            ClickLockDelayMs = SettingsHandler.GetClickLockDelay();
            SonarEnabled = SettingsHandler.GetMouseSonarState();
            CursorHiddenWhenTyping = SettingsHandler.GetMouseCursorHideWhenTypingState();
            Speed = SettingsHandler.GetMouseSpeed();
            AccelerationEnabled = accelerationParams[0] != 0 || accelerationParams[1] != 0 || accelerationParams[2] != 0;
            AccelerationSpeed = accelerationParams[2];
            AccelerationThreshold1 = accelerationParams[0];
            AccelerationThreshold2 = accelerationParams[1];
            HoverHeight = SettingsHandler.GetMouseHoverHeight();
            HoverWidth = SettingsHandler.GetMouseHoverWidth();
            HoverDelayMs = SettingsHandler.GetMouseHoverDelay();
            MouseTrails = SettingsHandler.GetMouseTrailsValue();
            ScrollTargetBehavior = SettingsHandler.GetMouseScrollBehavior();
            CursorSnapsToDefaultButton = SettingsHandler.GetMouseSnapToDefaultButtonState();
            HorizontalScrollCharCount = SettingsHandler.GetHorizontalScrollCharCount();
            VerticalScrollLineCount = SettingsHandler.GetVerticalScrollLineCount();
            DoubleClickHeight = SettingsHandler.GetDoubleClickHeight();
            DoubleClickWidth = SettingsHandler.GetDoubleClickWidth();
            DoubleClickDelayMs = NativeMethods.GetDoubleClickTime();
            CursorSize = SettingsHandler.GetCursorSize();
        }
    }
}