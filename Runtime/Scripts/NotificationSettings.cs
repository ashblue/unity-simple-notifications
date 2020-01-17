using CleverCrow.Fluid.SimpleSettings;
using UnityEngine;

namespace CleverCrow.Fluid.SimpleNotifications {
    [CreateAssetMenu(menuName = "Fluid/Simple Notifications/Settings", fileName = "NotificationSettings")]
    public class NotificationSettings : SettingsBase<NotificationSettings> {
        [SerializeField]
        private NotificationController _canvasPrefab;

        public NotificationController CanvasPrefab => _canvasPrefab;
    }
}
