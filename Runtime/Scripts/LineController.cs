using UnityEngine;
using UnityEngine.UI;

namespace CleverCrow.Fluid.SimpleNotifications {
    public class LineController : MonoBehaviour {
        [SerializeField]
        private Text _text;

        public void Setup (string text) {
            _text.text = text;
        }

        public void DestroySelf () {
            Destroy(gameObject);
        }
    }
}

