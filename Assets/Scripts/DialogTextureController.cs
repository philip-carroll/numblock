using Assets.Scripts.Utils;
using UnityEngine;

public class DialogTextureController : SpriteController
{
    void Start()
    {
        float width = Screen.width * 0.75f;
        float height = Screen.height * 0.75f;

        button.rectTransform.localPosition = new Vector2(0, 0); // centre the help text on the screen
        button.rectTransform.sizeDelta = new Vector2(width, height);

        //Debug.Log("Screen width: " + Screen.width);
        //Debug.Log("Screen height: " + Screen.height);
        //Debug.Log("Image width: " + width);
        //Debug.Log("Image height: " + height);
        //Debug.Log("Image Y pos: " + (width - (Screen.height / 2)));
    }
}
