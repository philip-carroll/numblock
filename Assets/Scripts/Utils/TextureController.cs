using UnityEngine;

namespace Assets.Scripts.Utils
{
    public class TextureController : MonoBehaviour
    {
        public Texture2D normalTexture;
        public Texture2D pressedTexture;

        protected string scene;

        private bool pressed;

        void Update()
        {
            if (Input.touchCount > 0)
            {
                // Is the touch on the current texture
                bool hit = guiTexture.HitTest(Input.GetTouch(0).position);

                if (Input.GetTouch(0).phase == TouchPhase.Began && hit)
                {
                    pressed = true;
                    guiTexture.texture = pressedTexture;
                }
                else
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        if (pressed)
                        {
                            guiTexture.texture = normalTexture;
                            pressed = false;

                            if (hit)
                                LoadScene(scene);
                        }
                    }
            }
        }

        private void LoadScene(string scene)
        {
            if (scene == "exit")
                Application.Quit();
            else
                Application.LoadLevel(scene);
        }
    }
}
