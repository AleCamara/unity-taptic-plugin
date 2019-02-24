using System.Runtime.InteropServices;

namespace TapticPlugin
{
    public enum NotificationFeedback
    {
        Success,
        Warning,
        Error
    }

    public enum ImpactFeedback
    {
        Light,
        Medium,
        Heavy
    }

    public static class TapticManager
    {
        public static void PrepareNotification()
        {
            _unityTapticPrepareNotification();
        }

        public static void TriggerNotification(NotificationFeedback feedback)
        {
            _unityTapticTriggerNotification((int)feedback);
        }

        public static void PrepareSelection()
        {
            _unityTapticPrepareSelection();
        }

        public static void TriggerSelection()
        {
            _unityTapticTriggerSelection();
        }

        public static void PrepareImpact(ImpactFeedback feedback)
        {
            _unityTapticPrepareImpact((int)feedback);
        }

        public static void TriggerImpact(ImpactFeedback feedback)
        {
            _unityTapticTriggerImpact((int)feedback);
        }

        public static bool IsSupported()
        {
            return _unityTapticIsSupported();
        }

        #region DllImport

#if UNITY_IPHONE && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void _unityTapticPrepareNotification();
        [DllImport("__Internal")]
        private static extern void _unityTapticTriggerNotification(int type);
        [DllImport("__Internal")]
        private static extern void _unityTapticPrepareSelection();
        [DllImport("__Internal")]
        private static extern void _unityTapticTriggerSelection();
        [DllImport("__Internal")]
        private static extern void _unityTapticPrepareImpact(int style);
        [DllImport("__Internal")]
        private static extern void _unityTapticTriggerImpact(int style);
        [DllImport("__Internal")]
        private static extern bool _unityTapticIsSupported();
#else
        private static void _unityTapticPrepareNotification() {}
        private static void _unityTapticTriggerNotification(int type) {}
        private static void _unityTapticPrepareSelection() {}
        private static void _unityTapticTriggerSelection() {}
        private static void _unityTapticPrepareImpact(int style) {}
        private static void _unityTapticTriggerImpact(int style) {}
        private static bool _unityTapticIsSupported() { return false; }
#endif

        #endregion // DllImport
    }

}