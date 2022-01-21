using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class NavigationController : SpriteController
    {
        public Sprite pressedSprite;

        protected string direction;

        private bool pressed;
        private int frameCount;
        private int threshold = 5;

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