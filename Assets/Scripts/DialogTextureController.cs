using Assets.Scripts.Utils;
using UnityEngine;

public class DialogTextureController : SpriteController
{
    void Start()
    {
        float width = Screen.width * 0.75f;
        float height = Screen.height * 0.75f;

        button.rectTransform.localPosition = new Vector2(0, 0);
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
