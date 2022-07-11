using Assets.Scripts.Utils;
using UnityEngine;

public class GameOverTextureController : SpriteController
{
    void Start()
    {
        float width = Screen.width * 0.66f;
        float height = width / 4;

        button.rectTransform.localPosition = new Vector2(0, height / 2);
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
