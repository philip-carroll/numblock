using Assets.Scripts.Utils;
using UnityEngine;

public class HelpTextTextureController : SpriteController
{
    void Start()
    {
        float width = Screen.width * 0.8f;
        float height = width / 2;

        button.rectTransform.localPosition = new Vector2(0, 0); // centre the help text on the screen
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}