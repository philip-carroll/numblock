using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Utils
{
    public class TextureController : SpriteController
    {
        private bool hit;

        protected string scene;

        public Sprite pressedSprite;

        public void OnPointerDown()
        {
            hit = true;
            this.button.overrideSprite = pressedSprite;
        }

        public void OnPointerUp()
        {
            this.button.overrideSprite = null;
            if (hit)
                LoadScene(scene);
        }

        public void OnPointerExit()
        {
            hit = false;
        }

        protected void LoadScene(string scene)
        {
            if (scene == "exit")
                Application.Quit();
            else
                SceneManager.LoadScene(scene);
        }
    }
}