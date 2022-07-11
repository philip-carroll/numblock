using Assets.Scripts.Utils;
using UnityEngine;

public class RightTextureController : NavigationController
{
    void Start()
    {
        this.direction = "Right";

        float width = Screen.width / 6;
        float height = width;

        button.rectTransform.localPosition = new Vector2(width * 2, 0);
        button.rectTransform.sizeDelta = new Vector2(width, height);
    }
}
