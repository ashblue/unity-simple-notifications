using CleverCrow.Fluid.Utilities;

namespace CleverCrow.Fluid.SimpleNotifications {
    public class NotificationManager : Singleton<NotificationManager> {
        private NotificationController _notificationCanvas;

        public void AddLine (string text) {
            if (_notificationCanvas == null) {
                _notificationCanvas = Instantiate(NotificationSettings.Current.CanvasPrefab, transform);
            }

            _notificationCanvas.AddLine(text);
        }
    }
}
