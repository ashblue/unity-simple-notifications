using CleverCrow.Fluid.SimpleNotifications;
using UnityEngine;

public class NotificationController : MonoBehaviour {
    [SerializeField]
    private LineController _linePrefab;

    [SerializeField]
    private RectTransform _lineOutput;

    public void AddLine (string text) {
        var line = Instantiate(_linePrefab, _lineOutput);
        line.Setup(text);
        line.transform.SetSiblingIndex(0);
    }
}
