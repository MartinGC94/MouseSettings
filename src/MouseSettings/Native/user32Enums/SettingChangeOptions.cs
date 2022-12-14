using System;

namespace MouseSettings.Native.user32Enums
{
    [Flags()]
    internal enum UpdateFlags : uint
    {
        /// <summary>
        /// Do not update settings
        /// </summary>
        DoNotPublish = 0,
        /// <summary>
        /// Writes the new system-wide parameter setting to the user profile.
        /// </summary>
        SPIF_UPDATEINIFILE = 1,
        /// <summary>
        /// Broadcasts the WM_SETTINGCHANGE message after updating the user profile.
        /// </summary>
        SPIF_SENDCHANGE = 2,
        /// <summary>
        /// Saves the setting to the user profile and applies them to the current session
        /// </summary>
        SaveAndPublish = SPIF_UPDATEINIFILE | SPIF_SENDCHANGE
    }
}