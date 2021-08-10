using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Utils
{
    public class TextureController : MonoBehaviour
    {
        private bool hit;

        protected string scene;
        protected Image button;

        public Sprite pressedSprite;

        void Awake()
        {
            button = gameObject.GetComponent<Image>();
        }

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