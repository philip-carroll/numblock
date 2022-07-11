using Assets.Scripts.Utils;
using UnityEngine;

public class NumblockTextureController : SpriteController
{
    void Start()
    {
        float width = Screen.width * 0.95f;
        float height = width / 4;

        button.rectTransform.localPosition = new Vector2(0, height / 2); // centre the numblock text on the screen
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
