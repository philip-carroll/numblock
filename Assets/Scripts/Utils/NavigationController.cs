using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Utils
{
    public class NavigationController : MonoBehaviour
    {
        public Sprite pressedSprite;

        protected string direction;

        private Image button;
        private bool pressed;
        private int frameCount;
        private int threshold = 5;

        void Awake()
        {
            button = gameObject.GetComponent<Image>();
        }

        void Update()
        {
            if (pressed && frameCount >= threshold)
            {
                this.button.overrideSprite = null;
                pressed = false;
                frameCount = 0;
            }

            frameCount++;
        }

        public void OnPointerDown()
        {
            if (!GameManager.instance.gameOver)
            {
                this.button.overrideSprite = pressedSprite;
                pressed = true;
                frameCount = 0;
                GameManager.instance.direction = direction;
            }
        }
    }
}