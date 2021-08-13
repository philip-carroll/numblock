using UnityEngine;

public class LeftTextureController : MonoBehaviour
{
    public Texture2D normalTexture;
    public Texture2D pressedTexture;

    private bool pressed;
    private int frameCount;
    private int threshold = 5;

    void Start()
    {
        float width = Screen.width / 6;
        float height = width;

        //guiTexture.pixelInset = new Rect(
        //    Screen.width / 20,
        //    (Screen.height / 2) - (height / 2),
        //    width,
        //    height);
    }

    void Update()
    {
        if (pressed && frameCount >= threshold)
        {
            //guiTexture.texture = normalTexture;
            pressed = false;
            frameCount = 0;
        }

        if (!GameManager.instance.gameOver && Input.touchCount > 0)
        {
            bool hit = false; //guiTexture.HitTest(Input.GetTouch(0).position);

            if (Input.GetTouch(0).phase == TouchPhase.Began && hit)
            {
                //guiTexture.texture = pressedTexture;
                pressed = true;
                frameCount = 0;
                GameManager.instance.direction = "Left";
            }
        }

        frameCount++;
    }
}
