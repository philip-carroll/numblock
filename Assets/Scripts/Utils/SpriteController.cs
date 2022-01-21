using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Utils
{
    public class SpriteController : MonoBehaviour
    {
        protected Image button;

        private void Awake()
        {
            button = gameObject.GetComponent<Image>();
        }
    }
}