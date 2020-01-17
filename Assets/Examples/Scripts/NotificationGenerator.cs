using UnityEngine;

namespace CleverCrow.Fluid.SimpleNotifications.Examples {
    public class NotificationGenerator : MonoBehaviour {
        private float _countdown;

        [SerializeField]
        private string _message;

        [SerializeField]
        private float _delayMin = 0;

        [SerializeField]
        private float _delayMax = 5;

        private void Update () {
            _countdown -= Time.deltaTime;
            if (_countdown > 0) return;

            _countdown = Random.Range(_delayMin, _delayMax);
            NotificationManager.Instance.AddLine(_message);
        }
    }
}
